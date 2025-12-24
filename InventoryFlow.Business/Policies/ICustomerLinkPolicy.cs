using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Policies
{
    public interface ICustomerLinkPolicy
    {
        void ApplyCustomerLink(Sale sale);
    }
}
