using FluentValidation;
using UnitConversion.Application.DTOs;

namespace UnitConversion.Application.Validators
{
    public class ConversionRequestValidator : AbstractValidator<ConversionRequestDto>
    {
        public ConversionRequestValidator()
        {
            RuleFor(x => x.Category)
                .NotEmpty()
                .WithMessage("Category is required.");

            RuleFor(x => x.FromUnit)
                .NotEmpty()
                .WithMessage("FromUnit is required.");

            RuleFor(x => x.ToUnit)
                .NotEmpty()
                .WithMessage("ToUnit is required.");

            RuleFor(x => x.Value)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Value must be greater than or equal to zero.");
        }
    }
}
