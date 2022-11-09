using Microsoft.AspNetCore.Identity;
using PetHealth.Core.DTOs;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace PetHealth.Core.Interfaces
{
    public interface IUserService
    {
        //Task CheckRecoveryCodeExists(RecoveryCodeDTO dto, CancellationToken cancellationToken = default);
        //Task<AccountActivationInfoDTO> GetAccountActivationInfo(string userId, string code, CancellationToken cancellationToken = default);
        //Task<bool> CanImpersonate(string impersonatingUserId, string impersonatedUserId, CancellationToken cancellationToken = default);
        //Task<ImpersonateUserDTO> IsUserImpersonating(ClaimsPrincipal userClaims);
        //Task<List<PermissionDTO>> GetAllUserPermissions(string userId, CancellationToken cancellationToken);
        //Task<UserDTO> Invite(UserDTO dto, CancellationToken cancellationToken = default);
        //Task ResendInvitation(string userId, CancellationToken cancellationToken = default);
        //Task Activate(ResetPasswordDTO dto, CancellationToken cancellationToken = default);
        //Task ConfirmEmail(ConfirmEmailDTO dto, CancellationToken cancellationToken = default);
        Task<IdentityResult> Register(UserRegistrationDTO dto, CancellationToken cancellationToken = default);
        //Task<int> CheckPwnedPassword(UserRegistrationDTO userRegistrationData);
        //Task ResendEmailConfirmation(string userId, CancellationToken cancellationToken = default);
        //Task SendTestEmail(string userEmail, int emailTemplateId, IFormFileCollection files, CancellationToken cancellationToken = default);
        //Task NotifyUserOnEmailChanged(string userId, string oldEmail, CancellationToken cancellationToken = default);
        //Task ResetPassword(ResetPasswordDTO dto, CancellationToken cancellationToken, bool verify = true);
        Task<AuthResultDTO> Login(LoginDTO dto, CancellationToken cancellationToken = default);
        //Task Login(RecoveryCodeDTO dto, CancellationToken cancellationToken = default);
        //Task<SignInResult> TwoFactorAuthenticatorSignIn(string authenticatorCode);
        //Task<SignInResult> TwoFactorRecoveryCodeSignIn(string recoveryCode);
        Task Logout();

        Task<bool> ValidateUserAsync(LoginDTO loginDto);
        Task<string> CreateTokenAsync();

        Task<string> CreateLogoutTokenAsync();

    }
}
