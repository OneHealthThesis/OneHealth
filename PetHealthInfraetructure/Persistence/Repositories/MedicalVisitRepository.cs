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
    public class MedicalVisitRepository : IMedicalVisitRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<MedicalVisit> MedicalVisit;
        public MedicalVisitRepository(PetHealthContext context)
        {
            _context = context;
            MedicalVisit = context.MedicalVisits;
        }

        IQueryable<MedicalVisit> IRepository<MedicalVisit>.GetAll()
        {
            throw new NotImplementedException();
        }

        public MedicalVisit GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IMedicalVisitRepository.AddEntity(MedicalVisit entity)
        {
            throw new NotImplementedException();
        }

        void IMedicalVisitRepository.UpdateEntity(MedicalVisit current, MedicalVisit update)
        {
            throw new NotImplementedException();
        }

        void IMedicalVisitRepository.DeleteEntity(MedicalVisit entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<MedicalVisit> IMedicalVisitRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public MedicalVisit GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<MedicalVisit>.AddEntity(MedicalVisit entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<MedicalVisit>.UpdateEntity(MedicalVisit current, MedicalVisit update)
        {
            throw new NotImplementedException();
        }

        void IRepository<MedicalVisit>.DeleteEntity(MedicalVisit entity)
        {
            throw new NotImplementedException();
        }
    }
}
