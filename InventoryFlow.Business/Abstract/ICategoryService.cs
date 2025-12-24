using System.Diagnostics.CodeAnalysis;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(Category category);
        // We might not need Update/Delete for categories yet, but good we have
    }
}