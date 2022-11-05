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
    public class VaccineConsultationRepository : IVaccineConsultationRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<VaccineConsultation> VaccineConsultation;
        public VaccineConsultationRepository(PetHealthContext context)
        {
            _context = context;
            VaccineConsultation = context.VaccineConsultations;
        }

        IQueryable<VaccineConsultation> IRepository<VaccineConsultation>.GetAll()
        {
            throw new NotImplementedException();
        }

        public VaccineConsultation GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IVaccineConsultationRepository.AddEntity(VaccineConsultation entity)
        {
            throw new NotImplementedException();
        }

        void IVaccineConsultationRepository.UpdateEntity(VaccineConsultation current, VaccineConsultation update)
        {
            throw new NotImplementedException();
        }

        void IVaccineConsultationRepository.DeleteEntity(VaccineConsultation entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<VaccineConsultation> IVaccineConsultationRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public VaccineConsultation GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<VaccineConsultation>.AddEntity(VaccineConsultation entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<VaccineConsultation>.UpdateEntity(VaccineConsultation current, VaccineConsultation update)
        {
            throw new NotImplementedException();
        }

        void IRepository<VaccineConsultation>.DeleteEntity(VaccineConsultation entity)
        {
            throw new NotImplementedException();
        }
    }
}
