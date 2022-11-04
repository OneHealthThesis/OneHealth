using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class PrescriptionDrugRepository : IPrescriptionDrugRepository
    {
        private PetHealthContext _context;
        public readonly DbSet<PrescriptionDrug> PrescriptionDrug;
        public PrescriptionDrugRepository(PetHealthContext context)
        {
            _context = context;
            PrescriptionDrug = context.PrescriptionDrug;
        }

        IQueryable<PrescriptionDrug> IRepository<PrescriptionDrug>.GetAll()
        {
            throw new NotImplementedException();
        }

        public PrescriptionDrug GetById(long id)
        {
            throw new NotImplementedException();
        }

        void IPrescriptionDrugRepository.AddEntity(PrescriptionDrug entity)
        {
            throw new NotImplementedException();
        }

        void IPrescriptionDrugRepository.UpdateEntity(PrescriptionDrug current, PrescriptionDrug update)
        {
            throw new NotImplementedException();
        }

        void IPrescriptionDrugRepository.DeleteEntity(PrescriptionDrug entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<PrescriptionDrug> IPrescriptionDrugRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        public PrescriptionDrug GetById(object Id)
        {
            throw new NotImplementedException();
        }

        void IRepository<PrescriptionDrug>.AddEntity(PrescriptionDrug entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<PrescriptionDrug>.UpdateEntity(PrescriptionDrug current, PrescriptionDrug update)
        {
            throw new NotImplementedException();
        }

        void IRepository<PrescriptionDrug>.DeleteEntity(PrescriptionDrug entity)
        {
            throw new NotImplementedException();
        }
    }
}
