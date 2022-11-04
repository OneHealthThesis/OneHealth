using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IAllergiesRepository: IRepository<Allergies>
    {
        public new IQueryable<Allergies> GetAll();
        public Allergies GetById(long id);
        public new void AddEntity(Allergies entity);
        public new void UpdateEntity(Allergies current, Allergies update);
        public new void DeleteEntity(Allergies entity);
    }
}
