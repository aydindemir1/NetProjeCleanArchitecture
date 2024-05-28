﻿using Application.Brands.DTOs;
using Application.SharedDTOs;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Brands.Service
{
    public interface IBrandService
    {
        Task<ResponseModelDto<ImmutableList<BrandDto>>> GetAll();


        Task<ResponseModelDto<BrandDto?>> GetById(int id);

        Task<ResponseModelDto<ImmutableList<BrandDto>>> GetAllByPage(int page, int pageSize);


        Task<ResponseModelDto<int>> Create(BrandCreateRequestDto request);
        Task<ResponseModelDto<NoContent>> Update(int BrandId, BrandUpdateRequestDto request);

        Task<ResponseModelDto<NoContent>> UpdateBrandName(int id, string name);


        Task<ResponseModelDto<NoContent>> Delete(int id);
    }
}
