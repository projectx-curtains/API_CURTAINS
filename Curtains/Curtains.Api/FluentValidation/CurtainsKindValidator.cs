using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class CurtainsKindValidator : AbstractValidator<CurtainsKindDTO>
	{
		public CurtainsKindValidator()
		{
			RuleFor(a => a)
				.NotNull().WithMessage("Not null");
		}
	}
}
