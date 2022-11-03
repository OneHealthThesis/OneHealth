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
    public class DiseaseRepository : IDiseaseRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Disease> Disease;
        public DiseaseRepository(PetHealthContext context)
        {
            _context = context;
            Disease = context.Diseases;
        }

        IQueryable<Disease> IRepository<Disease>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Disease GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IDiseaseRepository.AddEntity(Disease entity)
        {
            throw new NotImplementedException();
        }

        void IDiseaseRepository.UpdateEntity(Disease current, Disease update)
        {
            throw new NotImplementedException();
        }

        void IDiseaseRepository.DeleteEntity(Disease entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Disease> IDiseaseRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Disease GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Disease>.AddEntity(Disease entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Disease>.UpdateEntity(Disease current, Disease update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Disease>.DeleteEntity(Disease entity)
        {
            throw new NotImplementedException();
        }
    }
}
