using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using System.Linq;
using CompanyEmployees.Entities.DTO;
using Entities.Models;

namespace CompanyEmployees.Entities.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>().ForMember(d => d.FullAdress, opt => opt.MapFrom(x => $"{x.Address} {x.Country}"));
        }
    }
}
