using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class ProductSetValidator : AbstractValidator<ProductSetDTO>
	{
		public ProductSetValidator()
		{
			RuleFor(m => m)
				.NotNull().WithMessage("Not null");
		}
	}
}
