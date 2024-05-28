using Application.Brands.DTOs;
using Application.Brands.Repository;
using Application.SharedDTOs;
using AutoMapper;
using Domain.Brands;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Brands.Service
{
    public class BrandService(IBrandRepository BrandRepository, IUnitOfWork unitOfWork, IMapper mapper)
         : IBrandService
    {
        
        public async Task<ResponseModelDto<int>> Create(BrandCreateRequestDto request)
        {
           
            var newBrand = new Brand
            {
                Name = request.Name.Trim(),
                CreatedDate = DateTime.Now
            };

            await BrandRepository.Create(newBrand);
            await unitOfWork.CommitAsync();

            return ResponseModelDto<int>.Success(newBrand.Id, HttpStatusCode.Created);
        }

        public async Task<ResponseModelDto<NoContent>> Delete(int id)
        {
            
            await BrandRepository.Delete(id);
            await unitOfWork.CommitAsync();
            return ResponseModelDto<NoContent>.Success(HttpStatusCode.NoContent);
        }

        public async Task<ResponseModelDto<ImmutableList<BrandDto>>> GetAllByPage(int page, int pageSize)
        {
            var BrandsList = await BrandRepository.GetAllByPage(page, pageSize);


            var BrandListAsDto = mapper.Map<List<BrandDto>>(BrandsList);

            return ResponseModelDto<ImmutableList<BrandDto>>.Success(BrandListAsDto.ToImmutableList());
        }

        public async Task<ResponseModelDto<ImmutableList<BrandDto>>> GetAll(
            )
        {
            
            var brandList = await BrandRepository.GetAll();


            var BrandListAsDto = mapper.Map<List<BrandDto>>(brandList);


            return ResponseModelDto<ImmutableList<BrandDto>>.Success(BrandListAsDto.ToImmutableList());
        }

        public async Task<ResponseModelDto<BrandDto?>> GetById(int id)
        {
            var hasBrand = await BrandRepository.GetById(id);

            var BrandAsDto = mapper.Map<BrandDto>(hasBrand);

            return ResponseModelDto<BrandDto?>.Success(BrandAsDto);
        }

        public async Task<ResponseModelDto<NoContent>> Update(int BrandId, BrandUpdateRequestDto request)
        {

            var hasBrand = await BrandRepository.GetById(BrandId);


            hasBrand.Name = request.Name;



            await BrandRepository.Update(hasBrand);


            await unitOfWork.CommitAsync();
            return ResponseModelDto<NoContent>.Success(HttpStatusCode.NoContent);
        }

        public async Task<ResponseModelDto<NoContent>> UpdateBrandName(int id, string name)
        {
            await BrandRepository.UpdateBrandName(name, id);

            await unitOfWork.CommitAsync();

            return ResponseModelDto<NoContent>.Success(HttpStatusCode.NoContent);
        }


    }
}
