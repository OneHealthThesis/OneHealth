using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IMedicalVisitRepository : IRepository<MedicalVisit>
    {
        public new IQueryable<MedicalVisit> GetAll();
        public MedicalVisit GetById(long id);
        public new void AddEntity(MedicalVisit entity);
        public new void UpdateEntity(MedicalVisit current, MedicalVisit update);
        public new void DeleteEntity(MedicalVisit entity);
    }
}
