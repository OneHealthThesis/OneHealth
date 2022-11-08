using PetHealth.Core.Interfaces.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.DTOs
{
    public class LongIdNameDTO: IDTO<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }

        //public LongIdNameDTO(ILongIdName longIdName)
        //{
        //    Id = longIdName.Id;
        //    Name = longIdName.Name;
        //}
    }
}
