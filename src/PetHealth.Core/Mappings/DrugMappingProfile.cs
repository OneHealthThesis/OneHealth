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
    public class DrugMappingProfile: Profile
    {
        public DrugMappingProfile()
        {
            CreateMap<LongIdNameDTO, Drug>()
                .ForMember(src => src.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(src => src.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(src => src.CreatedOnDBDate, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
