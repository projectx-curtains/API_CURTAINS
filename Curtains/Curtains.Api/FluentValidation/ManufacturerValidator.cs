using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class ManufacturerValidator : AbstractValidator<ManufacturerDTO>
	{
		public ManufacturerValidator()
		{
			RuleFor(m => m)
				.NotNull().WithMessage("Not null");
		}
	}
}
