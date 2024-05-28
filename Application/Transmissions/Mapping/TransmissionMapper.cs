using Application.Transmissions.DTOs;
using AutoMapper;
using Domain.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Transmissions.Mapping
{
    public class TransmissionMapper : Profile
    {
        public TransmissionMapper()
        {
            CreateMap<Transmission, TransmissionDto>().ReverseMap();
            CreateMap<Transmission, TransmissionNameUpdateRequestDto>().ReverseMap();
            CreateMap<Transmission, TransmissionUpdateRequestDto>().ReverseMap();
            CreateMap<Transmission, TransmissionCreateRequestDto>().ReverseMap();

        }
    }
}
