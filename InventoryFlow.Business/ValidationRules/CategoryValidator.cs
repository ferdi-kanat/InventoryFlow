using FluentValidation;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Category name cannot be empty.")
                .MinimumLength(3).WithMessage("Category name must be at least 3 characters.");
        }
    }
}