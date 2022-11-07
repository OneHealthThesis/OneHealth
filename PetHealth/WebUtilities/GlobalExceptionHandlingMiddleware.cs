using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using PetHealth.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetHealth.WebUtilities
{
    public class GlobalExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger _logger;
        public GlobalExceptionHandlingMiddleware(RequestDelegate requestDelegate)
        {
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (BusinessException e)
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;

                string json = JsonSerializer.Serialize(e.Message);

                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(json);
            }
            catch (Exception e)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                string error = "Internal Server Error: please contact the support team";

                string json = JsonSerializer.Serialize(error);

                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(json);

            }
        }
    }
}
