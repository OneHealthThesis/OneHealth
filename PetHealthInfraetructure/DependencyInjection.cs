using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.Infrastructure.Persistence.Contexts;
using PetHealth.Infrastructure.Persistence.Repositories;
using System.Text;

namespace PetHealth.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var defaultConnectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<PetHealthContext>(options =>
                options.UseSqlServer(defaultConnectionString));

            // Configure Identity
            services.AddIdentity<ApplicationUser, Role>(options => {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                //Other options go here
            })
            .AddEntityFrameworkStores<PetHealthContext>()
            .AddDefaultTokenProviders();


            // JWT configuration.
            var jwtConfig = configuration.GetSection("jwtConfig");
            var secretKey = jwtConfig["secret"];
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtConfig["validIssuer"],
                    ValidAudience = jwtConfig["validAudience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
                };
            });


            //services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPetHealthContext, PetHealthContext>();
            services.AddScoped<IDataService<IPetHealthContext>, DataService<IPetHealthContext>>();
            
            services.AddScoped<IUserService, UserService>();
            services.AddScoped< ISyncService, SyncService>();
            return services;
        }

       
    }
}