using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PetHealth.Core.DTOs;
using PetHealth.Core.Exceptions;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.Infrastructure.Persistence.Contexts;
using System;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using ClaimTypes = System.Security.Claims.ClaimTypes;

namespace PetHealth.Controllers
{
    [Produces("application/json")]
    [Route("api/account"), ResponseCache(NoStore = true)]
    [ApiController]
    public class AccountApiController : ControllerBase
    {
        ILogger<AccountApiController> _logger;
        private readonly IUserService _userService;
        private readonly IPetHealthContext _dataContext;

        private const string Scheme = "https"; // hardcoded because Request.Scheme not reliable with load balanced architecture especially with Azure


        public AccountApiController(
            IUserService userService,
            ILogger<AccountApiController> logger,
            IPetHealthContext dataContext)
        {
            _logger = logger;
            _userService = userService;
            _dataContext = dataContext;
        }

        
        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDTO dto, CancellationToken cancellationToken = default)
        {
            var result = await _userService.Register(dto, cancellationToken);
            _logger.LogInformation($"Registered user: {dto.Email}");
            return result.Succeeded ? StatusCode(201) : new BadRequestObjectResult(result);
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginDTO dto, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await this._userService.ValidateUserAsync(dto);
                
                return !result ? Unauthorized() : Ok(new { 
                    Token = await this._userService.CreateTokenAsync(),
                    LoggedUser = await this._userService.Login(dto, cancellationToken)
                });
            }
            catch (UserNotExistsException)
            {
                _logger.LogDebug($"User not exists. Please use a valid user");
                return BadRequest();

            }
            catch (Exception exception)
            {
                _logger.LogDebug(exception.Message);

                
                return BadRequest(exception.Message);
            }
        }



        [HttpGet]
        [AllowAnonymous]
        [Authorize]
        public IActionResult TestGet()
        {
            return Ok("test endpoint working.");
        }

        [HttpPost]
        [Route("logout")]
        [Authorize]
        public async Task<IActionResult> Logout([FromBody] LoginDTO dto)
        {
            await _userService.Logout();
            _logger.LogInformation("User logged out successfully.");

            var result = await this._userService.ValidateUserAsync(dto);
            
            if (!result) {return Unauthorized(); }
            else
            {
                await this._userService.CreateLogoutTokenAsync();
                return NoContent();
            }

        }

        
    }
}