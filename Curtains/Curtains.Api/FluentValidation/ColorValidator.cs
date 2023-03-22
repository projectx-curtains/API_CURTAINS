using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class ColorValidator : AbstractValidator<ColorDTO>
	{
		public ColorValidator()
		{
			RuleFor(c => c)
				.NotNull().WithMessage("Not null");
		}
	}
}
