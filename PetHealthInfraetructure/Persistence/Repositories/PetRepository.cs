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
    public class PetRepository : IPetRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Pet> Pet;
        public PetRepository(PetHealthContext context)
        {
            _context = context;
            Pet = context.Pets;
        }

        IQueryable<Pet> IRepository<Pet>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Pet GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IPetRepository.AddEntity(Pet entity)
        {
            throw new NotImplementedException();
        }

        void IPetRepository.UpdateEntity(Pet current, Pet update)
        {
            throw new NotImplementedException();
        }

        void IPetRepository.DeleteEntity(Pet entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Pet> IPetRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Pet GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Pet>.AddEntity(Pet entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Pet>.UpdateEntity(Pet current, Pet update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Pet>.DeleteEntity(Pet entity)
        {
            throw new NotImplementedException();
        }
    }
}
