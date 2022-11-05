using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<Note> Note;
        public NoteRepository(PetHealthContext context)
        {
            _context = context;
            Note = context.Notes;
        }

        IQueryable<Note> IRepository<Note>.GetAll()
        {
            throw new NotImplementedException();
        }

        public Note GetById(long id)
        {
            throw new NotImplementedException();
        }

        void INoteRepository.AddEntity(Note entity)
        {
            throw new NotImplementedException();
        }

        void INoteRepository.UpdateEntity(Note current, Note update)
        {
            throw new NotImplementedException();
        }

        void INoteRepository.DeleteEntity(Note entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<Note> INoteRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public Note GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Note>.AddEntity(Note entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Note>.UpdateEntity(Note current, Note update)
        {
            throw new NotImplementedException();
        }

        void IRepository<Note>.DeleteEntity(Note entity)
        {
            throw new NotImplementedException();
        }
    }
}
