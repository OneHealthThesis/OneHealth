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
    public class AccountProfile: Profile
    {
        public AccountProfile()
        {
            CreateMap<ApplicationUser, UserDTO>()
                    .ForMember(d => d.Permissions, m => m.MapFrom(s => s.UserPermissions))
                    .ForMember(d => d.LastLogged, opts => opts.Ignore())
                    .ForMember(d => d.Password, opts => opts.Ignore())
                    .ForMember(d => d.ConfirmPassword, opts => opts.Ignore())
                .ReverseMap()
                    .ForMember(d => d.NormalizedEmail, m => m.MapFrom(s => s.Email.ToUpperInvariant()))
                    .ForMember(d => d.NormalizedUserName, m => m.MapFrom(s => s.UserName.ToUpperInvariant()))
                    .ForMember(d => d.UserPermissions, m => m.Ignore());
        }
    }
}
