using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class BedspreadsValidator : AbstractValidator<BedspreadsDTO>
	{
		public BedspreadsValidator()
		{
			RuleFor(a => a)
				.NotNull().WithMessage("Not null");
		}
	}
}