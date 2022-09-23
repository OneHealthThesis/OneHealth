﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;
using PetHealth.Infrastructure.Persistence.Repositories;

namespace PetHealthInfraetructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");

            //services.AddDbContext<PetHealthContext>(options =>
            //    options);

            services.AddScoped<IPersonService, PersonService>();

            return services;
        }
    }
}