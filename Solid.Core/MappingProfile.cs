using AutoMapper;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile() {
            CreateMap<Event, EventDTO>().ReverseMap();
            CreateMap<Halls, HallsDTO>().ReverseMap();
            CreateMap<Invited, InvitedDTO>().ReverseMap();
        
        
        }

    }
}
