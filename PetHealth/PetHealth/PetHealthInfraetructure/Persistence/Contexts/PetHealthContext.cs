using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Infrastructure.Persistence.Contexts
{
    public class PetHealthContext: IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public PetHealthContext(DbContextOptions<PetHealthContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        
    }
}
