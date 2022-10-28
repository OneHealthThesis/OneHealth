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
    public class PetHealthContext : IdentityDbContext<ApplicationUser, Role, string>
    {
        public PetHealthContext(DbContextOptions<PetHealthContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person_Pet>()
                .HasKey(p => new { p.PetId, p.PersonId });

        }

        public DbSet<ApplicationUser> Persons { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Person_Pet> PersonHasPet { get; set; }


        public DbSet<Allergies> Allergies { get; set; }
        public DbSet<AllergyConsultation> AllergyConsultations { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<LabTest> LabTests { get; set; }
        public DbSet<MedicalVisit> MedicalVisits { get; set; }
        public DbSet<Pathology> Pathologies { get; set; }
        public DbSet<PrescriptionDrug> PrescriptionDrug { get; set; }
        public DbSet<Radiology> Radiologies { get; set; }
        public DbSet<Surgeries> Surgeries { get; set; }
        public DbSet<Vaccines> Vaccines { get; set; }
        public DbSet<VaccineConsultation> VaccineConsultations { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
