using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.Interfaces
{
    public interface IDiseaseRepository:
        ICrudHandler<Disease, LongIdNameDTO, long>,
        IEntityGetAll<LongIdNameDTO, long>
    {
        //public new IQueryable<Disease> GetAll();
        //public Disease GetById(long id);
        //public new void AddEntity(Disease entity);
        //public new void UpdateEntity(Disease current, Disease update);
        //public new void DeleteEntity(Disease entity);
    }
}
