using AutoMapper;
using IdentityAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAPIProject
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Register, User>().ForMember(u => u.UserName, opt => opt.MapFrom(u => u.Email));
        }
    }
}
