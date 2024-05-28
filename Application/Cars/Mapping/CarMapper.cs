using Application.Cars.DTOs;
using AutoMapper;
using Domain.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cars.Mapping
{
    public class CarMapper : Profile
    {
        public CarMapper()
        {
            CreateMap<Car, CarDto>().ReverseMap();
            CreateMap<Car, CarUpdateRequestDto>().ReverseMap();
            CreateMap<Car, CarCreateRequestDto>().ReverseMap();

        }
    }
}
