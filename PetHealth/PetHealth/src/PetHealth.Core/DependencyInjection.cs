using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace PetHealth.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}