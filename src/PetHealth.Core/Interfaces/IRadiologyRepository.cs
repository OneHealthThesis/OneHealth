using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.Interfaces
{
    public interface IRadiologyRepository: IRepository<Radiology>
    {
        public new IQueryable<Radiology> GetAll();
        public Radiology GetById(long id);
        public new void AddEntity(Radiology entity);
        public new void UpdateEntity(Radiology current, Radiology update);
        public new void DeleteEntity(Radiology entity);
    }
}
