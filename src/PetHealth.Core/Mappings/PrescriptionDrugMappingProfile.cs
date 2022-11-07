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
    public class PrescriptionDrugMappingProfile: Profile
    {
        public PrescriptionDrugMappingProfile()
        {
            CreateMap<PrescriptionDrugDTO, PrescriptionDrug>()
                .ForMember(src => src.Id, opt => opt.MapFrom(opt => opt.Id))
                .ForMember(src => src.PersonId, opt => opt.MapFrom(opt => opt.PersonId))
                .ForMember(src => src.PetId, opt => opt.MapFrom(opt => opt.PetId))
                .ForMember(src => src.Date, opt => opt.MapFrom(opt => opt.Date))
                .ForMember(src => src.Place, opt => opt.MapFrom(opt => opt.Place))
                .ForMember(src => src.Doctor, opt => opt.MapFrom(opt => opt.Doctor))
                .ForMember(src => src.Notes, opt => opt.MapFrom(opt => opt.Notes))
                .ForMember(src => src.CreatedOnDBDate, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
