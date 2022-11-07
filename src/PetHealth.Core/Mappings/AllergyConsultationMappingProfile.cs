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
    public class AllergyConsultationMappingProfile: Profile
    {
        public AllergyConsultationMappingProfile()
        {
            CreateMap<AllergyConsultationDTO, AllergyConsultation>()
                .ForMember(src => src.Id, opt => opt.MapFrom(dto => dto.Id))
                .ForMember(src => src.PetId, opt => opt.MapFrom(dto => dto.PetId))
                .ForMember(src => src.Notes, opt => opt.MapFrom(dto => dto.Notes))
                .ForMember(src => src.AllergyId, opt => opt.MapFrom(dto => dto.AllergyId))
                .ForMember(src => src.Date, opt => opt.MapFrom(dto => dto.Date))
                .ForMember(src => src.PersonId, opt => opt.MapFrom(dto => dto.PersonId))
                .ForMember(src => src.CreatedOnDBDate, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
