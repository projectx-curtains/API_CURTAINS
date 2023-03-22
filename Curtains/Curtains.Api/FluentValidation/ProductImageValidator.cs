using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class ProductImageValidator : AbstractValidator<ProductImageDTO>
	{
		public ProductImageValidator()
		{
			RuleFor(m => m)
				.NotNull().WithMessage("Not null");
		}
	}
}
