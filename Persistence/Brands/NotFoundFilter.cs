using Application.Brands.DTOs;
using Application.Brands.Repository;
using Application.SharedDTOs;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Persistence.Brands
{
    public class NotFoundFilter(IBrandRepository BrandRepository) : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var actionName = ((ControllerBase)context.Controller).ControllerContext.ActionDescriptor.ActionName;


            var BrandIdFromAction = context.ActionArguments.Values.First()!;
            int BrandId = 0;

            if (actionName == "UpdateBrandName" &&
                BrandIdFromAction is BrandNameUpdateRequestDto brandNameUpdateRequestDto)
            {
                BrandId = brandNameUpdateRequestDto.Id;
            }


            if (BrandId == 0 && !int.TryParse(BrandIdFromAction.ToString(), out BrandId))
            {
                return;
            }

            var hasBrand = BrandRepository.HasExist(BrandId).Result;

            if (!hasBrand)
            {
                var errorMessage = $"There is no Brand with id: {BrandId}";

                var responseModel = ResponseModelDto<NoContent>.Fail(errorMessage);
                context.Result = new NotFoundObjectResult(responseModel);
            }


        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
