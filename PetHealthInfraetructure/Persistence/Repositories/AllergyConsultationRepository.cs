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
    public class AllergyConsultationRepository : IAllergyConsultationRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<AllergyConsultation> AllergyConsultation;
        public AllergyConsultationRepository(PetHealthContext context)
        {
            _context = context;
            AllergyConsultation = context.AllergyConsultations;
        }

        IQueryable<AllergyConsultation> IRepository<AllergyConsultation>.GetAll()
        {
            throw new NotImplementedException();
        }

        public AllergyConsultation GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IAllergyConsultationRepository.AddEntity(AllergyConsultation entity)
        {
            throw new NotImplementedException();
        }

        void IAllergyConsultationRepository.UpdateEntity(AllergyConsultation current, AllergyConsultation update)
        {
            throw new NotImplementedException();
        }

        void IAllergyConsultationRepository.DeleteEntity(AllergyConsultation entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<AllergyConsultation> IAllergyConsultationRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public AllergyConsultation GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<AllergyConsultation>.AddEntity(AllergyConsultation entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<AllergyConsultation>.UpdateEntity(AllergyConsultation current, AllergyConsultation update)
        {
            throw new NotImplementedException();
        }

        void IRepository<AllergyConsultation>.DeleteEntity(AllergyConsultation entity)
        {
            throw new NotImplementedException();
        }
    }
}
