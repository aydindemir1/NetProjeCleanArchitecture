using Application.Transmissions.DTOs;
using Application.Transmissions.Repository;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Transmissions.Validator
{
    public class TransmissionCreateRequestValidator : AbstractValidator<TransmissionCreateRequestDto>
    {
        public TransmissionCreateRequestValidator(ITransmissionRepository TransmissionRepository)
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull().WithMessage("{PropertyName} is required")
                .Length(3, 15).WithMessage("{PropertyName} must be between 3 and 15 characters");




        }
    }
}
