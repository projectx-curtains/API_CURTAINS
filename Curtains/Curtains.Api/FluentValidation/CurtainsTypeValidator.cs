using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class CurtainsTypeValidator : AbstractValidator<CurtainsTypeDTO>
	{
		public CurtainsTypeValidator()
		{
			RuleFor(a => a)
				.NotNull().WithMessage("Not null");
		}
	}
}
