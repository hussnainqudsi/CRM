using AutoMapper;
using Domain.Entities;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Leads, LeadsDto>().ReverseMap();
            CreateMap<Description, DescriptionDto>().ReverseMap();
            CreateMap<Society, SocietyDto>().ReverseMap();
        }
    }
}
