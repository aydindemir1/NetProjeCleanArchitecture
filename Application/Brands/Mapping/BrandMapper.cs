using Application.Brands.DTOs;
using AutoMapper;
using Domain.Brands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Brands.Mapping
{
    public class BrandMapper : Profile
    {
        public BrandMapper()
        {
            CreateMap<Brand, BrandDto>().ReverseMap();
            CreateMap<Brand, BrandNameUpdateRequestDto>().ReverseMap();
            CreateMap<Brand, BrandUpdateRequestDto>().ReverseMap();
            CreateMap<Brand, BrandCreateRequestDto>().ReverseMap();

        }
    }
}
