using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.Entities;
using PetHealth.Core.Interfaces.CoreInterfaces;

namespace PetHealth.Core.DTOs.EntityDTO
{
    public class PetDTO: IDTO<long>
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Breed { get; set; }

        public string Gender { get; set; }

        public string BloodType { get; set; }
    }
}
