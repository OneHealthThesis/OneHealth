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
    public class PathologyRepository : IPathologyRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Pathology> Pathology;
        public PathologyRepository(PetHealthContext context)
        {
            _context = context;
            Pathology = context.Pathologies;
        }

        IQueryable<Pathology> IRepository<Pathology>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Pathology GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IPathologyRepository.AddEntity(Pathology entity)
        {
            throw new NotImplementedException();
        }

        void IPathologyRepository.UpdateEntity(Pathology current, Pathology update)
        {
            throw new NotImplementedException();
        }

        void IPathologyRepository.DeleteEntity(Pathology entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Pathology> IPathologyRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Pathology GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Pathology>.AddEntity(Pathology entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Pathology>.UpdateEntity(Pathology current, Pathology update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Pathology>.DeleteEntity(Pathology entity)
        {
            throw new NotImplementedException();
        }
    }
}
