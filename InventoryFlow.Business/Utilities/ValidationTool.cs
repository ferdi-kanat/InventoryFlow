using FluentValidation;

namespace InventoryFlow.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            ArgumentNullException.ThrowIfNull(validator);

            ArgumentNullException.ThrowIfNull(entity);

            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);

            if (!result.IsValid)
            {
                // If there are errors, throw an exception with the first error message.
                throw new ValidationException(result.Errors[0].ErrorMessage);
            }
        }
    }
}