using InventoryFlow.DataAccess.Abstract;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, InventoryContext>, ICategoryDal
    {
    }
}