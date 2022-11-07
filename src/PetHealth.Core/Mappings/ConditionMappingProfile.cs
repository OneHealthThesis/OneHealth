using AutoMapper;
using PetHealth.Core.DTOs.EntityDTO;
using PetHealth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealth.Core.Mappings
{
    public class ConditionMappingProfile: Profile
    {
        public ConditionMappingProfile()
        {
            CreateMap<ConditionDTO, Condition>()
                .ForMember(src => src.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(src => src.PersonId, opt => opt.MapFrom(dto => dto.PersonId))
                .ForMember(src => src.PetId, opt => opt.MapFrom(dto => dto.PetId))
                .ForMember(src => src.DiseaseId, opt => opt.MapFrom(dto => dto.DiseaseId))
                .ForMember(src => src.Date, opt => opt.MapFrom(dto => dto.Date))
                .ForMember(src => src.Place, opt => opt.MapFrom(dto => dto.Place))
                .ForMember(src => src.Doctor, opt => opt.MapFrom(dto => dto.Doctor))
                .ForMember(src => src.Notes, opt => opt.MapFrom(dto => dto.Notes))
                .ForMember(src => src.CreatedOnDBDate, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
