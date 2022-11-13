using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Infrastructure.Persistence.Contexts
{
    public class SeedData
    {
        private static string[] allergies = { "Harina","Polen", "Saliva de la Pulga","Cerdo","Pollo","Cereales","Soja" };
        private static string[] diseases = { "Virosis", "Parvovirosis","Moquillo","Hepatitis","Rabia","Leptospirosis","Filarias" };
        private static string[] drugs = { "Amoxicillina", "Ampicilina","Gentamicina", "Ciflutrín", "Metronidazol",  "Tilmicosin" };
        private static string[] vaccines = { "Distemper", "Parvovirus","Rabia", "Leptospirosis", "Hepatitis" };


        private static PetHealthContext GetContext(IServiceProvider service)
        {
            return service.GetRequiredService<PetHealthContext>();
        }

        private static IServiceProvider GetServiceProvider(IApplicationBuilder app)
        {
            return app.ApplicationServices.CreateScope().ServiceProvider;
        }

        public static void Seed(IApplicationBuilder app)
        {
            var serviceProvider = GetServiceProvider(app);
            EnsurePopulated(GetContext(serviceProvider), serviceProvider);
        }

        public static void EnsurePopulated(PetHealthContext petHealthContext, IServiceProvider service = null)
        {
            var context = petHealthContext;
            context.Database.Migrate();
           
            if (!context.Allergies.Any())
            {
                foreach (var item in allergies)
                {
                    context.Allergies.Add(new()
                    {
                        Name = item
                    });
                }
            }
            if (!context.Diseases.Any())
            {
                foreach (var item in diseases)
                {
                    context.Diseases.Add(new()
                    {
                        Name = item
                    });
                }
            }
            if (!context.Drugs.Any())
            {
                foreach (var item in drugs)
                {
                    context.Drugs.Add(new()
                    {
                        Name = item
                    });
                }
            }
            if (!context.Vaccines.Any())
            {
                foreach (var item in vaccines)
                {
                    context.Vaccines.Add(new()
                    {
                        Name = item
                    });
                }
            }

            context.SaveChanges();
        }
    }
}
