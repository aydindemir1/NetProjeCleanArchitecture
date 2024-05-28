using Application.Models.DTOs;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Mapping
{
    public class ModelMapper : Profile
    {
        public ModelMapper()
        {
            CreateMap<Model, ModelDto>().ReverseMap();
            CreateMap<Model, ModelNameUpdateRequestDto>().ReverseMap();
            CreateMap<Model, ModelUpdateRequestDto>().ReverseMap();
            CreateMap<Model, ModelCreateRequestDto>().ReverseMap();

        }
    }
}
