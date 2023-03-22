using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class FabricValidator : AbstractValidator<FabricDTO>
	{
		public FabricValidator()
		{
			RuleFor(a => a)
				.NotNull().WithMessage("Not null");
		}
	}
}
