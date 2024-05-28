using Application.Models.DTOs;
using Application.Models.Repository;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Validator
{
    public class ModelCreateRequestValidator : AbstractValidator<ModelCreateRequestDto>
    {
        public ModelCreateRequestValidator(IModelRepository ModelRepository)
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required")
                .Length(2, 50).WithMessage("{PropertyName} must be between 3 and 50 characters");

            RuleFor(x => x.BrandId)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(x => x.FuelId)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(x => x.TransmissionId)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required")
                .Length(3, 20).WithMessage("{PropertyName} must be between 3 and 20 characters");
        }



    }
}
