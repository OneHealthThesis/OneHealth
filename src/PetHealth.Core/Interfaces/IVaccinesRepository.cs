using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.Interfaces
{
    public interface IVaccinesRepository: IRepository<Vaccines>
    {
        public new IQueryable<Vaccines> GetAll();
        public Vaccines GetById(long id);
        public new void AddEntity(Vaccines entity);
        public new void UpdateEntity(Vaccines current, Vaccines update);
        public new void DeleteEntity(Vaccines entity);
    }
}
