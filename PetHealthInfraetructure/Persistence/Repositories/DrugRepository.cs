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
    public class DrugRepository : IDrugRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Drug> Drug;
        public DrugRepository(PetHealthContext context)
        {
            _context = context;
            Drug = context.Drugs;
        }

        IQueryable<Drug> IRepository<Drug>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Drug GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IDrugRepository.AddEntity(Drug entity)
        {
            throw new NotImplementedException();
        }

        void IDrugRepository.UpdateEntity(Drug current, Drug update)
        {
            throw new NotImplementedException();
        }

        void IDrugRepository.DeleteEntity(Drug entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Drug> IDrugRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Drug GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Drug>.AddEntity(Drug entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Drug>.UpdateEntity(Drug current, Drug update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Drug>.DeleteEntity(Drug entity)
        {
            throw new NotImplementedException();
        }
    }
}
