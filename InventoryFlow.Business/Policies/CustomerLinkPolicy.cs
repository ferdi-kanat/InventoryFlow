using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Policies
{
    public class CustomerLinkPolicy : ICustomerLinkPolicy
    {
        public void ApplyCustomerLink(Sale sale)
        {
            ArgumentNullException.ThrowIfNull(sale);

            sale.CustomerId = sale.CustomerId == 0 ? null : sale.CustomerId;
        }
    }
}
