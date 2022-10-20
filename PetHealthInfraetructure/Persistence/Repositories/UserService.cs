using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

//using Castle.Core.Internal;

//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using PetHealth.Core.Exceptions;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Utils;
using PetHealth.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;


//using ClaimTypes = BBWM.Core.Membership.Model.ClaimTypes;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UrlEncoder _urlEncoder;
        private readonly IMapper _mapper;
        private readonly PetHealthContext _context;

        public UserService(
            
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            //IOptionsSnapshot<UserLoginSettings> loginSettingsOptions,
            IHttpContextAccessor httpContextAccessor,
            UrlEncoder urlEncoder,
            PetHealthContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            
            _httpContextAccessor = httpContextAccessor;
            _urlEncoder = urlEncoder;
        }

        private string DomainUrl => $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host.Value}";


        public async Task Register(UserRegistrationDTO dto, CancellationToken cancellationToken = default)
        {
            var existingUser = await _userManager.FindByEmailAsync(dto.Email);
            if (existingUser != null)
                throw new BusinessException($"User with email {dto.Email} already exists.");


            var user = new ApplicationUser
            {
                UserName = dto.Email,
                FirstName = dto.FirstName?.Trim(),
                LastName = dto.LastName?.Trim(),
                Email = dto.Email,
                Id = Guid.NewGuid().ToString(),
            };


            var result = await _userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
                throw new BusinessException(result.Errors.First().Description);

           
            await _userManager.UpdateAsync(user);

        }

        
        public async Task<AuthResultDTO> Login(LoginDTO dto, CancellationToken cancellationToken = default)
        {
            var currentIp = _httpContextAccessor.HttpContext.GetUserIp();

            

            var user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.Email == dto.Email, cancellationToken);

            // Whether user with specified email exist
            if (user == null)
            {
                throw new UserNotExistsException();
            }


            // Check password
            if (!await _userManager.CheckPasswordAsync(user, dto.Password))
            {
                throw new WrongCredentialsException("Incorrect user name or password.");
            }

            //We use SignInAsync instead of PasswordSignInAsync because SignInAsync contains custom logging logic
            await _signInManager.SignInAsync(user, new AuthenticationProperties(), "Password");

            var loggedUser = _mapper.Map<UserDTO>(
                await _context.Users.FindAsync(user.Id));

            return new AuthResultDTO { UserId = user.Id, LoggedUser = loggedUser };
        }

        

        public async Task Logout() => await _signInManager.SignOutAsync();


        public static class ErrorMessages
        {
            public static readonly string RecoveryNotFoundForUser = "Recovery code not found for the user.";
            public static readonly string RecoveryExpired = "Recovery code has expired.";
            public static readonly string RecoveryInvalid = "Recovery code is invalid.";
            public static readonly string ActivationCompleted = "Activation already completed.";
            public static readonly string ActivationCodeInvalid = "Activation code is invalid.";
            public static readonly string InvitationNotFoundForUser = "Invitation not found for the user.";
            public static readonly string InvitationExpired = "Sorry, your link has expired. Please ask your administrator to resend the invitation.";
            public static readonly string ImpersonatingUserNotFound = "Impersonating user doesn't exist.";
            public static readonly string ImpersonatedUserNotFound = "Impersonated user doesn't exist.";
            public static readonly string EmailExistForDeleted = "User with this email already exists and has 'deleted' status. You should undelete the user on the user details page instead.";
            public static readonly string EmailExist = "User with this email already exists";
            public static readonly string UserNotActivatedForEmail = "User with email u.Email is not activated";
            public static readonly string UserAlreadyActivated = "User is already active.";
            public static readonly string WrongRecoveryCode = "Wrong recovery code";
            public static readonly string UndefinedEmail = "The email cannot be sent. Email address is undefined.";
            public static readonly string Disabled2FAOrU2F = "Cannot generate recovery codes for user as he does not have 2FA or U2F enabled";
            public static readonly string NoU2FChallenges = "There are no U2F registration challenges for this user";
        }
    }
}