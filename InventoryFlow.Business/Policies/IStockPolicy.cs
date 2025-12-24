using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Policies
{
    public interface IStockPolicy
    {
        Product ReserveStock(Sale sale);
    }
}
