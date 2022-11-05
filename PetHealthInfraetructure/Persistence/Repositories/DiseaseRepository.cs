using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces;
using PetHealth.Core.Interfaces.CoreInterfaces;
using PetHealth.Infrastructure.Persistence.Contexts;

namespace PetHealth.Infrastructure.Persistence.Repositories
{
    public class DiseaseRepository : IDiseaseRepository
    {
        private IPetHealthContext _context;
        public readonly DbSet<Disease> Disease;
        private readonly IDataService _dataService;
        public DiseaseRepository(IPetHealthContext context, IDataService dataService)
        {
            _context = context;
            Disease = context.Diseases;
            _dataService = dataService;
        }

        public async Task<LongIdNameDTO> Get(long id, CancellationToken ct = default)
            => await this._dataService.Get<Disease, LongIdNameDTO, long>(id, ct);

        public async Task<LongIdNameDTO> Create(LongIdNameDTO dto, CancellationToken ct = default)
            => await this._dataService.Create<Disease, LongIdNameDTO>(dto, ct);


        public async Task<LongIdNameDTO> Update(LongIdNameDTO dto, CancellationToken ct = default)
            => await this._dataService.Update<Disease, LongIdNameDTO, long>(dto, ct);

        public async Task Delete(long id, CancellationToken ct = default)
            => await this._dataService.Delete<Disease, long>(id, ct);

        public async Task<IEnumerable<LongIdNameDTO>> GetAll(CancellationToken ct = default)
            => await this._dataService.GetAll<Disease, LongIdNameDTO>();

        //IQueryable<Disease> IRepository<Disease>.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public Disease GetById(long id)
        //{
        //    throw new NotImplementedException();
        //}

        //void IDiseaseRepository.AddEntity(Disease entity)
        //{
        //    throw new NotImplementedException();
        //}

        //void IDiseaseRepository.UpdateEntity(Disease current, Disease update)
        //{
        //    throw new NotImplementedException();
        //}

        //void IDiseaseRepository.DeleteEntity(Disease entity)
        //{
        //    throw new NotImplementedException();
        //}

        //IQueryable<Disease> IDiseaseRepository.GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public Disease GetById(object Id)
        //{
        //    throw new NotImplementedException();
        //}

        //void IRepository<Disease>.AddEntity(Disease entity)
        //{
        //    throw new NotImplementedException();
        //}

        //void IRepository<Disease>.UpdateEntity(Disease current, Disease update)
        //{
        //    throw new NotImplementedException();
        //}

        //void IRepository<Disease>.DeleteEntity(Disease entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
