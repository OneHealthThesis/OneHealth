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
    public class SurgeriesRepository : ISurgeriesRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Surgeries> Surgeries;
        public SurgeriesRepository(PetHealthContext context)
        {
            _context = context;
            Surgeries = context.Surgeries;
        }

        IQueryable<Surgeries> IRepository<Surgeries>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Surgeries GetById(long id)
        {
            throw new NotImplementedException();
        }

        void ISurgeriesRepository.AddEntity(Surgeries entity)
        {
            throw new NotImplementedException();
        }

        void ISurgeriesRepository.UpdateEntity(Surgeries current, Surgeries update)
        {
            throw new NotImplementedException();
        }

        void ISurgeriesRepository.DeleteEntity(Surgeries entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Surgeries> ISurgeriesRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Surgeries GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Surgeries>.AddEntity(Surgeries entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Surgeries>.UpdateEntity(Surgeries current, Surgeries update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Surgeries>.DeleteEntity(Surgeries entity)
        {
            throw new NotImplementedException();
        }
    }
}
