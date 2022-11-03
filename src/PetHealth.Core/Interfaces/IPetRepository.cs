using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IPetRepository: IRepository<Pet>
    {
        public new IQueryable<Pet> GetAll();
        public Pet GetById(long id);
        public new void AddEntity(Pet entity);
        public new void UpdateEntity(Pet current, Pet update);
        public new void DeleteEntity(Pet entity);
    }
}
