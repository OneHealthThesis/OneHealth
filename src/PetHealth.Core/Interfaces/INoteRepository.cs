using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.Interfaces
{
    public interface INoteRepository : IRepository<Note>
    {
        public new IQueryable<Note> GetAll();
        public Note GetById(long id);
        public new void AddEntity(Note entity);
        public new void UpdateEntity(Note current, Note update);
        public new void DeleteEntity(Note entity);
    }
}
