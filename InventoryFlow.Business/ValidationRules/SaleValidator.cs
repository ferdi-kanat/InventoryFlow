using FluentValidation;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.ValidationRules
{
    public class SaleValidator : AbstractValidator<Sale>
    {
        public SaleValidator()
        {
            RuleFor(s => s.Quantity)
                .GreaterThan(0).WithMessage("Quantity must be at least 1.");
            // Note: We do NOT check "Stock Amount" here. 
            // Stock checks depend on the database state, so they stay in the Manager (Business Logic).
            // Validators are only for the OBJECT's properties (Input format).
        }
    }
}