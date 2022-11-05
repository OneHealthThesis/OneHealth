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
    public class RadiologyRepository : IRadiologyRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Radiology> Radiology;
        public RadiologyRepository(PetHealthContext context)
        {
            _context = context;
            Radiology = context.Radiologies;
        }

        IQueryable<Radiology> IRepository<Radiology>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Radiology GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IRadiologyRepository.AddEntity(Radiology entity)
        {
            throw new NotImplementedException();
        }

        void IRadiologyRepository.UpdateEntity(Radiology current, Radiology update)
        {
            throw new NotImplementedException();
        }

        void IRadiologyRepository.DeleteEntity(Radiology entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Radiology> IRadiologyRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Radiology GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Radiology>.AddEntity(Radiology entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Radiology>.UpdateEntity(Radiology current, Radiology update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Radiology>.DeleteEntity(Radiology entity)
        {
            throw new NotImplementedException();
        }
    }
}
