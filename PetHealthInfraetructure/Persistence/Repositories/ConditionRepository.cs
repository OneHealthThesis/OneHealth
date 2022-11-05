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
    public class ConditionRepository : IConditionRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Condition> Condition;
        public ConditionRepository(PetHealthContext context)
        {
            _context = context;
            Condition = context.Condition;
        }

        IQueryable<Condition> IRepository<Condition>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Condition GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IConditionRepository.AddEntity(Condition entity)
        {
            throw new NotImplementedException();
        }

        void IConditionRepository.UpdateEntity(Condition current, Condition update)
        {
            throw new NotImplementedException();
        }

        void IConditionRepository.DeleteEntity(Condition entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Condition> IConditionRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Condition GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Condition>.AddEntity(Condition entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Condition>.UpdateEntity(Condition current, Condition update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Condition>.DeleteEntity(Condition entity)
        {
            throw new NotImplementedException();
        }
    }
}
