using PetHealth.Core.DTOs;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace BBWM.Core.Membership.Services
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
        Task Register(UserRegistrationDTO dto, CancellationToken cancellationToken = default);
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
        //Task<UserDTO> Impersonate(string impersonatingUserId, string impersonatedUserId, CancellationToken cancellationToken = default);
        //Task<UserDTO> StopImpersonation(ClaimsPrincipal userClaims, CancellationToken cancellationToken = default);
        //Task RecoverPassword(RecoverPasswordDTO dto, CancellationToken cancellationToken = default);
        //Task<NameValueCollection> GetTagValues(string email, string url, string ipAddress);
        //Task Approve(string userId, CancellationToken cancellationToken);
        //Task ToggleLocking(string userId, CancellationToken cancellationToken = default);
        //Task ToggleDeleting(string userId, CancellationToken cancellationToken = default);
        //Task Enable2Fa(Enabling2FADTO dto, string userId, CancellationToken cancellationToken = default);
        //Task Disable2Fa(string userId, CancellationToken cancellationToken = default);
        //Task EnableU2F(string userId, CancellationToken cancellationToken = default);
        //Task DisableU2F(string userId, CancellationToken cancellationToken = default);
        //Task<string> Generate2FaOrU2FRecoveryCodes(string userId, CancellationToken cancellationToken = default);
        //Task<U2FRegistrationRequestDTO> GenerateU2FDeviceRegistrationChallenge(string userId, string appUrl, CancellationToken cancellationToken = default);
        //Task RegisterU2FDevice(string userId, U2FRegistrationResponseDTO dto, CancellationToken cancellationToken = default);
        //Task<List<U2FRegisteredKeysDTO>> GenerateU2FDeviceAuthenticationChallenges(string userId, string appUrl, CancellationToken cancellationToken = default);
        //Task CheckBrowserLoginAsync(AuthResultDTO result, string email, string fingerprint, CancellationToken cancellationToken);
        //Task AuthenticateU2FDevice(U2FAuthenticationResponseDTO dto, CancellationToken cancellationToken = default);
        //Task RefreshTwoFactorSetupClaims(User user = null, CancellationToken cancellationToken = default);

    }
}
