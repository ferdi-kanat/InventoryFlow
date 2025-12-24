using FluentValidation;
using InventoryFlow.Business.Commands;

namespace InventoryFlow.Business.ValidationRules
{
    public class SellProductCommandValidator : AbstractValidator<SellProductCommand>
    {
        public SellProductCommandValidator()
        {
            RuleFor(c => c.ProductId)
                .GreaterThan(0)
                .WithMessage("Please select a product.");

            RuleFor(c => c.Quantity)
                .GreaterThan(0)
                .WithMessage("Quantity must be a positive number.");

            RuleFor(c => c.CustomerId)
                .Must(id => id is null || id >= 0)
                .WithMessage("Invalid customer selection.");
        }
    }
}
