﻿using Application.SharedDTOs;
using Application.Transmissions.Repository;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Application.Transmissions.DTOs;

namespace Persistence.Transmissions
{
    public class NotFoundFilter(ITransmissionRepository TransmissionRepository) : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var actionName = ((ControllerBase)context.Controller).ControllerContext.ActionDescriptor.ActionName;


            var TransmissionIdFromAction = context.ActionArguments.Values.First()!;
            int TransmissionId = 0;

            if (actionName == "UpdateTransmissionName" &&
                TransmissionIdFromAction is TransmissionNameUpdateRequestDto TransmissionNameUpdateRequestDto)
            {
                TransmissionId = TransmissionNameUpdateRequestDto.Id;
            }


            if (TransmissionId == 0 && !int.TryParse(TransmissionIdFromAction.ToString(), out TransmissionId))
            {
                return;
            }

            var hasTransmission = TransmissionRepository.HasExist(TransmissionId).Result;

            if (!hasTransmission)
            {
                var errorMessage = $"There is no Transmission with id: {TransmissionId}";

                var responseModel = ResponseModelDto<NoContent>.Fail(errorMessage);
                context.Result = new NotFoundObjectResult(responseModel);
            }


        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
