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
    public class PetHealthContext: DbContext
    {
        public PetHealthContext(DbContextOptions<PetHealthContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Allergies>()
                .HasKey(c => new { c.PersonID, c.PetID });
            modelBuilder.Entity<LabTest>()
                .HasKey(c => new { c.PersonID, c.PetID });
            modelBuilder.Entity<MedicalVisit>()
                .HasKey(c => new { c.PersonID, c.PetID });
            modelBuilder.Entity<Pathology>()
                .HasKey(c => new { c.PersonID, c.PetID });
            modelBuilder.Entity<PrescriptionDrug>()
                .HasKey(c => new { c.PersonID, c.PetID });
            modelBuilder.Entity<Radiology>()
                .HasKey(c => new { c.PersonID, c.PetID });
            modelBuilder.Entity<Surgeries>()
                .HasKey(c => new { c.PersonID, c.PetID });
            modelBuilder.Entity<Vaccines>()
                .HasKey(c => new { c.PersonID, c.PetID });

        }

        public DbSet<Person> Persons { get; set; }

    }
}
