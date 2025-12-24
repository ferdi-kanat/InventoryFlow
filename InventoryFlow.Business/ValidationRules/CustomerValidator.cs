using FluentValidation;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.ValidationRules
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Last name is required.");

            RuleFor(c => c.Email)
                .EmailAddress().When(c => !string.IsNullOrEmpty(c.Email))
                .WithMessage("Please enter a valid email address.");
        }
    }
}