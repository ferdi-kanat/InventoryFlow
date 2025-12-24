using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Policies
{
    public interface IPricingPolicy
    {
        void ApplyPricing(Sale sale, Product product);
    }
}
