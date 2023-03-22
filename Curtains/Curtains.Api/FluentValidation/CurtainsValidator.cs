using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class CurtainsValidator : AbstractValidator<CurtainsDTO>
	{
		public CurtainsValidator()
		{
			RuleFor(a => a)
				.NotNull().WithMessage("Not null");
		}
	}
}
