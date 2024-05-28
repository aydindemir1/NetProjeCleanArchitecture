using Application.Models.Repository;
using Application.SharedDTOs;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Application.Models.DTOs;

namespace Persistence.Models
{
    public class NotFoundFilter(IModelRepository ModelRepository) : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {

            var actionName = ((ControllerBase)context.Controller).ControllerContext.ActionDescriptor.ActionName;


            var ModelIdFromAction = context.ActionArguments.Values.First()!;
            int ModelId = 0;

            if (actionName == "UpdateModelName" &&
                ModelIdFromAction is ModelNameUpdateRequestDto ModelNameUpdateRequestDto)
            {
                ModelId = ModelNameUpdateRequestDto.Id;
            }


            if (ModelId == 0 && !int.TryParse(ModelIdFromAction.ToString(), out ModelId))
            {
                return;
            }

            var hasModel = ModelRepository.HasExist(ModelId).Result;

            if (!hasModel)
            {
                var errorMessage = $"There is no Model with id: {ModelId}";

                var responseModel = ResponseModelDto<NoContent>.Fail(errorMessage);
                context.Result = new NotFoundObjectResult(responseModel);
            }


        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
