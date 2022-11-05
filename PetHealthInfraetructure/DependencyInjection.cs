using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.Infrastructure.Persistence.Contexts;
using PetHealth.Infrastructure.Persistence.Repositories;

namespace PetHealth.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<PetHealthContext>(options =>
                options.UseSqlServer(defaultConnectionString));
            //services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPetHealthContext, PetHealthContext>();
            services.AddScoped<IDataService<IPetHealthContext>, DataService<IPetHealthContext>>();
            
            services.AddScoped<IUserService, UserService>();
            services.AddScoped< ISyncService, SyncService>();
            return services;
        }

    }
}