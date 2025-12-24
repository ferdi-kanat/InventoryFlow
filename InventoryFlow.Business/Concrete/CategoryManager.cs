using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Utilities;
using InventoryFlow.Business.ValidationRules;
using InventoryFlow.DataAccess.Abstract;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);
            _categoryDal.Add(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}