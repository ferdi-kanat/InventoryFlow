using FluentValidation;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            // Rule 1: Product Name cannot be empty
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Product name cannot be empty.");

            // Rule 2: Product Name length
            RuleFor(p => p.Name)
                .MinimumLength(2).WithMessage("Product name must be at least 2 characters.");

            // Rule 3: Price must be greater than 0
            RuleFor(p => p.UnitPrice)
                .GreaterThan(0).WithMessage("Unit Price must be greater than 0.");

            // Rule 4: Stock cannot be negative
            RuleFor(p => p.StockAmount)
                .GreaterThanOrEqualTo(0).WithMessage("Stock amount cannot be negative.");

            // Rule 5 (Custom Example): If the Category is 1, Price must be at least 10
            RuleFor(p => p.UnitPrice)
                .GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1)
                .WithMessage("Products in Category 1 cannot be cheaper than 10");
        }
    }
}