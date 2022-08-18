using Microsoft.EntityFrameworkCore;

namespace dotnetapp.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ConsumerPet>()
            .HasKey(c => new { c.IdUser, c.IdPet });

        modelBuilder.Entity<Allergies>()
            .HasKey(c => new { c.IdClinicHistory, c.IdDrug });
    }

    public DbSet<Pet> Pets { get; set; }

    ///-------------
    public DbSet<Person> Users { get; set; }
    public DbSet<Provider> Providers { get; set; }
    public DbSet<Consumer> Consumers { get; set; }
    ///-----------
    public DbSet<ConsumerPet> Consumer_Has_Pet { get; set; }
    ///----------
    public DbSet<Service> Services { get; set; }
    public DbSet<Consultation> Consultations { get; set; }
    public DbSet<Hairdressing> Hairdressings { get; set; }
    ///--------
    
   
    public DbSet<Drug>Drugs { get; set; }
    public DbSet<PrescriptionDrug> PrescriptionDrugs { get; set; }
    
    public  DbSet<Questioning> Questionings { get; set; }
    public DbSet<PhysicalTest> PhysicalTest { get; set; }

    public DbSet<ClinicHistory> ClinicHistories { get; set; }
    public DbSet<Allergies> Allergies { get; set; }
    public DbSet<Traumas> Traumas { get; set; }
    public  DbSet<Transfusions> Transfusions { get; set; }
    public DbSet<Surgeries> Surgeries { get; set; }



}