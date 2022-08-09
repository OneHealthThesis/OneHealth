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
    }

    public DbSet<Pet> Pets { get; set; }
    public DbSet<Person> Users { get; set; }
    public  DbSet<ConsumerPet> Consumer_Has_Pet { get; set; }
    public DbSet<Consumer> Consumers { get; set; }
}