using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class AllergiesRepository : IAllergiesRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Allergies> Allergies;
        public AllergiesRepository(PetHealthContext context)
        {
            _context = context;
            Allergies = context.Allergies;
        }

        IQueryable<Allergies> IRepository<Allergies>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Allergies GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IAllergiesRepository.AddEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }

        void IAllergiesRepository.UpdateEntity(Allergies current, Allergies update)
        {
            throw new NotImplementedException();
        }

        void IAllergiesRepository.DeleteEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Allergies> IAllergiesRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Allergies GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Allergies>.AddEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Allergies>.UpdateEntity(Allergies current, Allergies update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Allergies>.DeleteEntity(Allergies entity)
        {
            throw new NotImplementedException();
        }
    }
}
