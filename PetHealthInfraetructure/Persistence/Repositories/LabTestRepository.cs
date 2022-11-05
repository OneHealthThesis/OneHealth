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
    public class LabTestRepository : ILabTestRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<LabTest> LabTest;
        public LabTestRepository(PetHealthContext context)
        {
            _context = context;
            LabTest = context.LabTests;
        }

        IQueryable<LabTest> IRepository<LabTest>.GetAll()
        {
            throw new NotImplementedException();
        }

        public LabTest GetById(long id)
        {
            throw new NotImplementedException();
        }

        void ILabTestRepository.AddEntity(LabTest entity)
        {
            throw new NotImplementedException();
        }

        void ILabTestRepository.UpdateEntity(LabTest current, LabTest update)
        {
            throw new NotImplementedException();
        }

        void ILabTestRepository.DeleteEntity(LabTest entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<LabTest> ILabTestRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public LabTest GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<LabTest>.AddEntity(LabTest entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<LabTest>.UpdateEntity(LabTest current, LabTest update)
        {
            throw new NotImplementedException();
        }

        void IRepository<LabTest>.DeleteEntity(LabTest entity)
        {
            throw new NotImplementedException();
        }
    }
}
