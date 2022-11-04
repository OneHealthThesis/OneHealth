using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IDrugRepository: IRepository<Drug>
    {
        public new IQueryable<Drug> GetAll();
        public Drug GetById(long id);
        public new void AddEntity(Drug entity);
        public new void UpdateEntity(Drug current, Drug update);
        public new void DeleteEntity(Drug entity);
    }
}
