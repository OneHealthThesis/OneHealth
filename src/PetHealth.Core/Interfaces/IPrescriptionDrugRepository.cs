using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IPrescriptionDrugRepository: IRepository<PrescriptionDrug>
    {
        public new IQueryable<PrescriptionDrug> GetAll();
        public PrescriptionDrug GetById(long id);
        public new void AddEntity(PrescriptionDrug entity);
        public new void UpdateEntity(PrescriptionDrug current, PrescriptionDrug update);
        public new void DeleteEntity(PrescriptionDrug entity);
    }
}
