using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class LambrequinsValidator : AbstractValidator<LambrequinsDTO>
	{
		public LambrequinsValidator()
		{
			RuleFor(a => a)
				.NotNull().WithMessage("Not null");
		}
	}
}
