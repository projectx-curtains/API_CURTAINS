using FluentValidation;
using Curtains.Application.DTO;

namespace Curtains.Api.FluentValidation
{
	public class AccessoriesValidator : AbstractValidator<AccessoriesDTO>
	{
		public AccessoriesValidator()
		{
			RuleFor(a => a.Furniture.Title)
				.NotNull()
				.NotEmpty()
				.NotEqual("string")
				.WithMessage("Title of furniture can't be empty");
			RuleFor(a => a.Furniture.Description)
				.NotNull()
				.NotEmpty()
				.NotEqual("string")
				.WithMessage("Description of furniture can't be empty");
			RuleFor(a => a.Bracing.Title)
				.NotNull()
				.NotEmpty()
				.NotEqual("string")
				.WithMessage("Title of bracing can't be empty");
			RuleFor(a => a.Bracing.Description)
				.NotNull()
				.NotEmpty()
				.NotEqual("string")
				.WithMessage("Description of bracing can't be empty");
			RuleFor(a => a.ColorGroup.Title)
				.NotNull()
				.NotEmpty()
				.NotEqual("string")
				.WithMessage("Title of color group can't be empty");
			RuleFor(a => a.Manufacturer.Country)
				.NotNull()
				.NotEmpty()
				.NotEqual("string")
				.WithMessage("Manufacturer country can't be empty");				
		}
	}
}
