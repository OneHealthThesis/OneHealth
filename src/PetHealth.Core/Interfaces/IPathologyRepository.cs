using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;

namespace PetHealth.Core.Interfaces
{
    public interface IPathologyRepository: IRepository<Pathology>
    {
        public new IQueryable<Pathology> GetAll();
        public Pathology GetById(long id);
        public new void AddEntity(Pathology entity);
        public new void UpdateEntity(Pathology current, Pathology update);
        public new void DeleteEntity(Pathology entity);
    }
}
