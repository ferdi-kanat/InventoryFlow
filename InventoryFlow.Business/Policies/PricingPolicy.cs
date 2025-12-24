using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Policies
{
    public class PricingPolicy : IPricingPolicy
    {
        public void ApplyPricing(Sale sale, Product product)
        {
            ArgumentNullException.ThrowIfNull(sale);
            ArgumentNullException.ThrowIfNull(product);

            sale.TotalPrice = product.UnitPrice * sale.Quantity;
            sale.Date = DateTime.Now;
        }
    }
}
