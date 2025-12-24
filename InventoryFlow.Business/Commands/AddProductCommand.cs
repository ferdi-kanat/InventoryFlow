using System.Globalization;
using FluentValidation;
using InventoryFlow.Business.Utilities;
using InventoryFlow.Business.ValidationRules;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Commands
{
    public class AddProductCommand
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? UnitPriceText { get; set; }
        public string? StockAmountText { get; set; }
        public object? CategoryValue { get; set; }

        public Product ToProduct(Product? existing)
        {
            var product = existing ?? new Product();

            product.Name = Name ?? string.Empty;
            product.UnitPrice = ParseUnitPrice();
            product.StockAmount = ParseStockAmount();
            product.CategoryId = ParseCategoryId();

            ValidationTool.Validate(new ProductValidator(), product);

            return product;
        }

        private int ParseCategoryId()
        {
            if (CategoryValue == null)
            {
                throw new ValidationException("Please select a category.");
            }

            try
            {
                var categoryId = Convert.ToInt32(CategoryValue, CultureInfo.InvariantCulture);
                if (categoryId <= 0)
                {
                    throw new ValidationException("Please select a category.");
                }

                return categoryId;
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException || ex is InvalidCastException)
            {
                throw new ValidationException("Invalid category selection.");
            }
        }

        private decimal ParseUnitPrice()
        {
            if (!decimal.TryParse(UnitPriceText, NumberStyles.Number, CultureInfo.CurrentCulture, out var price))
            {
                throw new ValidationException("Please enter a valid unit price.");
            }

            return price;
        }

        private int ParseStockAmount()
        {
            if (!int.TryParse(StockAmountText, NumberStyles.Integer, CultureInfo.CurrentCulture, out var stock))
            {
                throw new ValidationException("Please enter a valid stock amount.");
            }

            return stock;
        }
    }
}
