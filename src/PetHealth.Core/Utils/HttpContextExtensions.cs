using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Security.Claims;

namespace PetHealth.Core.Utils
{
    public static class HttpContextExtensions
    {
        public static string GetUserId(this HttpContext httpContext)
           => httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

        public static string? GetUserIp(this HttpContext httpContext)
        {
            var header = httpContext.Request?.Headers["X-Real-IP"];
            if (header?.Any() ?? false)
                return header?.First();

            return httpContext.Connection?.RemoteIpAddress?.MapToIPv4().ToString();
        }
    }
}
