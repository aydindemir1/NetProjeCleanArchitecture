﻿using Application.SharedDTOs;
using Application.Transmissions.DTOs;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Transmissions.Service
{
    public interface ITransmissionService
    {
        Task<ResponseModelDto<ImmutableList<TransmissionDto>>> GetAll();


        Task<ResponseModelDto<TransmissionDto?>> GetById(int id);

        Task<ResponseModelDto<ImmutableList<TransmissionDto>>> GetAllByPage(int page, int pageSize);


        Task<ResponseModelDto<int>> Create(TransmissionCreateRequestDto request);
        Task<ResponseModelDto<NoContent>> Update(int TransmissionId, TransmissionUpdateRequestDto request);

        Task<ResponseModelDto<NoContent>> UpdateTransmissionName(int id, string name);


        Task<ResponseModelDto<NoContent>> Delete(int id);
    }
}
