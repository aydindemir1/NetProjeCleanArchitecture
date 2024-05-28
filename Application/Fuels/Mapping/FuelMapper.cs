using Application.Fuels.DTOs;
using AutoMapper;
using Domain.Fuels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Fuels.Mapping
{
    public class FuelMapper : Profile
    {
        public FuelMapper()
        {
            CreateMap<Fuel, FuelDto>().ReverseMap();
            CreateMap<Fuel, FuelNameUpdateRequestDto>().ReverseMap();
            CreateMap<Fuel, FuelUpdateRequestDto>().ReverseMap();
            CreateMap<Fuel, FuelCreateRequestDto>().ReverseMap();

        }
    }

}
