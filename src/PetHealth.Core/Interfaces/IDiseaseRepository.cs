using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IDiseaseRepository: IRepository<Disease>
    {
        public new IQueryable<Disease> GetAll();
        public Disease GetById(long id);
        public new void AddEntity(Disease entity);
        public new void UpdateEntity(Disease current, Disease update);
        public new void DeleteEntity(Disease entity);
    }
}
