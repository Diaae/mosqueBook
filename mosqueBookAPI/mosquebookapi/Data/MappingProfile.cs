using AutoMapper;
using mosquebookapi.Dto;
using mosquebookapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mosquebookapi.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Mosque, MosqueDto>().ReverseMap();
            CreateMap<EventType, EventTypeDto>().ReverseMap();
            CreateMap<Event, EventDto>().ReverseMap();
            CreateMap<Appointment, AppointmentDto>().ReverseMap();
            CreateMap<EventGroup, EventGroupDto>().ReverseMap();
        }
    }
}
