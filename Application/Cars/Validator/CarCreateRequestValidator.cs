using Application.Cars.DTOs;
using Application.Cars.Repository;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cars.Validator
{
    public class CarCreateRequestValidator : AbstractValidator<CarCreateRequestDto>
    {
        public CarCreateRequestValidator(ICarRepository CarRepository)
        {
            RuleFor(x => x.ModelId)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(x => x.Kilometer)
             .NotEmpty().WithMessage("{PropertyName} is required")
             .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(x => x.ModelYear)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull().WithMessage("{PropertyName} is required");

            RuleFor(x => x.Plate)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required")
                .Length(6, 15).WithMessage("{PropertyName} must be between 6 and 15 characters");






        }
    }
}
