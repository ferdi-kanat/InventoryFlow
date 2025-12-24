using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        // Custom category operations can go here
    }
}