using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class DecorationsValidator : AbstractValidator<DecorationsDTO>
	{
		public DecorationsValidator()
		{
			RuleFor(a => a)
				.NotNull().WithMessage("Not null");
		}
	}
}
