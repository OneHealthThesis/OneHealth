using AutoMapper;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.Mappings
{
    public class GeneralProfile: Profile
    {
        public GeneralProfile()
        {
            CreateMap<CreatePersonDTO, Person>();
            CreateMap<Person, PersonDTO>();
        }
    }
}
