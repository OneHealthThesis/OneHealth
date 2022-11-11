using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

//using Castle.Core.Internal;

//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using PetHealth.Core.Exceptions;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.Core.Utils;
using PetHealth.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
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
        private readonly IPetHealthContext _context;
        private readonly IConfiguration _configuration;
        private ApplicationUser? _user;

        public UserService(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, IHttpContextAccessor httpContextAccessor,
            IPetHealthContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        private string DomainUrl => $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host.Value}";


        public async Task<IdentityResult> Register(UserRegistrationDTO dto, CancellationToken cancellationToken = default)
        {

            var user = new ApplicationUser
            {
                UserName = dto.PhoneNumber,
                FirstName = dto.FirstName?.Trim(),
                LastName = dto.LastName?.Trim(),
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                Version = "0.0.0.1",
                Id = Guid.NewGuid().ToString(),
            };


            var result = await _userManager.CreateAsync(user, dto.Password);
            if (result.Succeeded)
            {
                var pet1 = new Pet
                {
                    Birthday = new DateTime(),
                    BloodType = "type not set",
                    Breed = "not set",
                    Gender = "not set",
                    Name = "not set"
                };

                var pet2 = new Pet
                {
                    Birthday = new DateTime(),
                    BloodType = "type not set",
                    Breed = "not set",
                    Gender = "not set",
                    Name = "not set"
                };

                var addedPet1 = this._context.Pets.Add(pet1);
                var addedPet2 = this._context.Pets.Add(pet2);
                await this._context.SaveChangesAsync(cancellationToken);

                this._context.PersonHasPet.Add(new Person_Pet { PersonId = user.Id, PetId = pet1.Id });
                this._context.PersonHasPet.Add(new Person_Pet { PersonId = user.Id, PetId = pet2.Id });

                await this._context.SaveChangesAsync(cancellationToken);

            }

            return result;

        }

        
        public async Task<AuthResultDTO> Login(LoginDTO dto, CancellationToken cancellationToken = default)
        {

            //var user = await _userManager.Users
            //    .FirstOrDefaultAsync(u => u.Email == dto.Email && u.PhoneNumber == dto.PhoneNumber, cancellationToken);

            //// Whether user with specified email exist
            //if (user == null)
            //{
            //    throw new UserNotExistsException();
            //}


            //// Check password
            //if (!await _userManager.CheckPasswordAsync(user, dto.Password))
            //{
            //    throw new WrongCredentialsException("Incorrect user name or password.");
            //}

            ////We use SignInAsync instead of PasswordSignInAsync because SignInAsync contains custom logging logic
            //await _signInManager.SignInAsync(user, new AuthenticationProperties(), "Password");

            var loggedUser = _mapper.Map<UserDTO>(_user);
                //await _context.Persons.FindAsync(_user.Id));

            var petsIds = this._context.PersonHasPet
                .Where(entity => entity.PersonId == loggedUser.Id)
                .Select(entity => entity.PetId)
                .ToList();

            return new AuthResultDTO { UserId = _user.Id, LoggedUser = loggedUser, PetsIds = petsIds };
        }



        public async Task Logout()
        {
            await _signInManager.SignOutAsync();

        }


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


        public async Task<bool> ValidateUserAsync(LoginDTO loginDto)
        {
            _user = await _userManager.FindByNameAsync(loginDto.PhoneNumber);
            var result = _user != null && await _userManager.CheckPasswordAsync(_user, loginDto.Password);
            return result;

        }

        public async Task<string> CreateLogoutTokenAsync()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims, "expired");
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        public async Task<string> CreateTokenAsync()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims, "expiresIn");
            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }


        private SigningCredentials GetSigningCredentials()
        {
            var jwtConfig = _configuration.GetSection("jwtConfig");
            var key = Encoding.UTF8.GetBytes(jwtConfig["Secret"]);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }


        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, _user.UserName)
            };
            var roles = await _userManager.GetRolesAsync(_user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims, string loginOption)
        {
            var jwtSettings = _configuration.GetSection("JwtConfig");
            var tokenOptions = new JwtSecurityToken
            (
            issuer: jwtSettings["validIssuer"],
            audience: jwtSettings["validAudience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(Convert.ToDouble(jwtSettings[loginOption])),
            signingCredentials: signingCredentials
            );
            return tokenOptions;
        }

    }
}