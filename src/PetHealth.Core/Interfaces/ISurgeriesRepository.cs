using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.Interfaces
{
    public interface ISurgeriesRepository: IRepository<Surgeries>
    {
        public new IQueryable<Surgeries> GetAll();
        public Surgeries GetById(long id);
        public new void AddEntity(Surgeries entity);
        public new void UpdateEntity(Surgeries current, Surgeries update);
        public new void DeleteEntity(Surgeries entity);
    }
}
