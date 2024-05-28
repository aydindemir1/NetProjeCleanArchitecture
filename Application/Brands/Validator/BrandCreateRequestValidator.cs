using Application.Brands.DTOs;
using Application.Brands.Repository;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Brands.Validator
{
    public class BrandCreateRequestValidator : AbstractValidator<BrandCreateRequestDto>
    {
        public BrandCreateRequestValidator(IBrandRepository BrandRepository)
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required")
                .Length(3, 10).WithMessage("{PropertyName} must be between 3 and 10 characters");




        }
    }
}
