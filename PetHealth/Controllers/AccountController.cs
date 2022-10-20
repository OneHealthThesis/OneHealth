using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PetHealth.Core.DTOs;
using PetHealth.Core.Exceptions;
using PetHealth.Core.Interfaces;
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
    public class AccountApiController : Controller
    {
        ILogger<AccountApiController> _logger;
        private readonly IUserService _userService;
        private readonly PetHealthContext _dataContext;

        private const string Scheme = "https"; // hardcoded because Request.Scheme not reliable with load balanced architecture especially with Azure


        public AccountApiController(
            IUserService userService,
            ILogger<AccountApiController> logger,
            PetHealthContext dataContext)
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
            await _userService.Register(dto, cancellationToken);
            _logger.LogInformation($"Registered user: {dto.Email}");
            return Ok();
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginDTO dto, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await _userService.Login(dto, cancellationToken);
                return Ok(result);
            }
            catch (UserNotExistsException)
            {
                _logger.LogDebug($"User is not exists. Try to find a pharmax user");
                return BadRequest();

            }
            catch (Exception exception)
            {
                _logger.LogDebug($"Dialog popup: {exception.Message}.");

                
                return BadRequest(exception.Message);
            }
        }



        [HttpGet]
        [AllowAnonymous]
        public IActionResult TestGet()
        {
            return Ok("test endpoint working.");
        }

        [HttpPost]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await _userService.Logout();
            _logger.LogInformation("User logged out successfully.");
            return NoContent();
        }

        
    }
}