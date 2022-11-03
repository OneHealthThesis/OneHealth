using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IVaccineConsultationRepository: IRepository<VaccineConsultation>
    {
        public new IQueryable<VaccineConsultation> GetAll();
        public VaccineConsultation GetById(long id);
        public new void AddEntity(VaccineConsultation entity);
        public new void UpdateEntity(VaccineConsultation current, VaccineConsultation update);
        public new void DeleteEntity(VaccineConsultation entity);
    }
}
