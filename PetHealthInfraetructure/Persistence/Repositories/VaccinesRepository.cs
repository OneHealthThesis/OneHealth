using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class VaccinesRepository : IVaccinesRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Vaccines> Vaccines;
        public VaccinesRepository(PetHealthContext context)
        {
            _context = context;
            Vaccines = context.Vaccines;
        }

        IQueryable<Vaccines> IRepository<Vaccines>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Vaccines GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IVaccinesRepository.AddEntity(Vaccines entity)
        {
            throw new NotImplementedException();
        }

        void IVaccinesRepository.UpdateEntity(Vaccines current, Vaccines update)
        {
            throw new NotImplementedException();
        }

        void IVaccinesRepository.DeleteEntity(Vaccines entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Vaccines> IVaccinesRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Vaccines GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Vaccines>.AddEntity(Vaccines entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Vaccines>.UpdateEntity(Vaccines current, Vaccines update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Vaccines>.DeleteEntity(Vaccines entity)
        {
            throw new NotImplementedException();
        }
    }
}
