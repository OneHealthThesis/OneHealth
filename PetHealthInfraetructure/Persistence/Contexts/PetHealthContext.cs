using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetapp.PetHealth.PetHealth.src.PetHealth.Core.Entities;

namespace PetHealth.Infrastructure.Persistence.Contexts
{
    public class PetHealthContext: IdentityDbContext<ApplicationUser, Role, string>
    {
        public PetHealthContext(DbContextOptions<PetHealthContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Allergies>()
                .HasKey(c => new { c.PersonID, c.PetID });


        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        
    }
}
