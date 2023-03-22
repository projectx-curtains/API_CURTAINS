using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class PillowsValidator : AbstractValidator<PillowsDTO>
	{
		public PillowsValidator()
		{
			RuleFor(m => m)
				.NotNull().WithMessage("Not null");
		}
	}
}
