using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.Interfaces
{
    public interface ILabTestRepository : IRepository<LabTest>
    {
        public new IQueryable<LabTest> GetAll();
        public LabTest GetById(long id);
        public new void AddEntity(LabTest entity);
        public new void UpdateEntity(LabTest current, LabTest update);
        public new void DeleteEntity(LabTest entity);
    }
}
