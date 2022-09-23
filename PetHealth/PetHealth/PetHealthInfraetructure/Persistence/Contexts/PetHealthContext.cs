using Microsoft.EntityFrameworkCore;
using PetHealth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Infrastructure.Persistence.Contexts
{
    public class PetHealthContext: DbContext
    {
        public PetHealthContext(DbContextOptions<PetHealthContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

    }
}
