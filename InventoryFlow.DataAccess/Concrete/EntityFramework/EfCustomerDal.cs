using InventoryFlow.DataAccess.Abstract;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, InventoryContext>, ICustomerDal
    {
    }
}