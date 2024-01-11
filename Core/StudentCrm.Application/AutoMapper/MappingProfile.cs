using AutoMapper;
using StudentCrm.Application.DTOs.EventDTOs;
using StudentCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrm.Application.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Event,EventCreateDTO>().ReverseMap();

        }

    }
}
