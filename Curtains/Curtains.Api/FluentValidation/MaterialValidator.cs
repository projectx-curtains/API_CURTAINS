using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class MaterialValidator : AbstractValidator<MaterialDTO>
	{
		public MaterialValidator()
		{
			RuleFor(m => m)
				.NotNull().WithMessage("Not null");
		}
	}
}
