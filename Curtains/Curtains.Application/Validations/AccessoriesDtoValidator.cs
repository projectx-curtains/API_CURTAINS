using Curtains.Application.DTO.Interfaces;
using FluentValidation;

namespace Curtains.Application.Validations;

public class AccessoriesDtoValidator : AbstractValidator<IAccessoriesDto>
{
    public AccessoriesDtoValidator()
    {
        RuleFor(x => x.Price)
            .NotEmpty().WithMessage("Price is required")
            .NotNull()
            .GreaterThan(0);

        RuleFor(x => x.Color)
            .NotNull().WithMessage("Accesories is Required")
            .NotEmpty();
    }
}