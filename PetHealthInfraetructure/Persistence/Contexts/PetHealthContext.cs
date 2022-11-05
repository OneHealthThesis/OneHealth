using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Infrastructure.Persistence.Contexts
{
    public class PetHealthContext : IdentityDbContext<ApplicationUser, Role, string>, IPetHealthContext
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
        public DbSet<Condition> Condition { get; set; }
        public DbSet<Disease> Diseases { get; set; }
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


        public async Task UpdateManyAsync<TEntity>(List<TEntity> items, CancellationToken cancellationToken) where TEntity : class
        {
            Set<TEntity>().UpdateRange(items);
            await SaveChangesAsync(cancellationToken);
            items.ForEach(DetachEntry);
        }

        public async Task UpdateManyBatchedAsync<TEntity>(IEnumerable<TEntity> items, int batchSize, CancellationToken cancellationToken) where TEntity : class
        {
            var itemsList = items.ToList();
            var skip = 0;
            for (var j = 0; j < itemsList.Count; j += batchSize)
            {
                var itemsSubset = itemsList.Skip(skip).Take(batchSize).ToList();
                await UpdateManyAsync(itemsSubset, cancellationToken);

                skip += batchSize;
            }
        }

        public void DetachEntry<TEntity>(TEntity entry) where TEntity : class
        {
            Entry(entry).State = EntityState.Detached;
        }
    }
}
