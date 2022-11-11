using AutoMapper;
using PetHealth.Core.DTOs;
using PetHealth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetHealth.Core.DTOs.EntityDTO;

namespace PetHealth.Core.Mappings
{
    public class PetMappingProfile: Profile
    {
        public PetMappingProfile()
        {
            CreateMap<PetDTO, Pet>()
                .ForMember(src => src.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(src => src.Name, opt => opt.MapFrom(dto => dto.Name))
                .ForMember(src => src.Birthday, opt => opt.MapFrom(dto => dto.Birthday))
                .ForMember(src => src.BloodType, opt => opt.MapFrom(dto => dto.BloodType))
                .ForMember(src => src.Breed, opt => opt.MapFrom(dto => dto.Breed))
                .ForMember(src => src.Gender, opt => opt.MapFrom(dto => dto.Gender))
                .ReverseMap();
        }
    }
}
