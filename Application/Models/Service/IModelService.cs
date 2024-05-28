using Application.Models.DTOs;
using Application.SharedDTOs;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Service
{
    public interface IModelService
    {
        Task<ResponseModelDto<ImmutableList<ModelDto>>> GetAll();


        Task<ResponseModelDto<ModelDto?>> GetById(int id);

        Task<ResponseModelDto<ImmutableList<ModelDto>>> GetAllByPage(int page, int pageSize);


        Task<ResponseModelDto<int>> Create(ModelCreateRequestDto request);
        Task<ResponseModelDto<NoContent>> Update(int ModelId, ModelUpdateRequestDto request);

        Task<ResponseModelDto<NoContent>> UpdateModelName(int id, string name);


        Task<ResponseModelDto<NoContent>> Delete(int id);
    }
}
