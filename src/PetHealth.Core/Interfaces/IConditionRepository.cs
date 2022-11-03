using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IConditionRepository: IRepository<Condition>
    {
        public new IQueryable<Condition> GetAll();
        public Condition GetById(long id);
        public new void AddEntity(Condition entity);
        public new void UpdateEntity(Condition current, Condition update);
        public new void DeleteEntity(Condition entity);
    }
}
