using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IAllergyConsultationRepository: IRepository<AllergyConsultation>
    {
        public new IQueryable<AllergyConsultation> GetAll();
        public AllergyConsultation GetById(long id);
        public new void AddEntity(AllergyConsultation entity);
        public new void UpdateEntity(AllergyConsultation current, AllergyConsultation update);
        public new void DeleteEntity(AllergyConsultation entity);
    }
}
