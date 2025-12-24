using System.Diagnostics.CodeAnalysis;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;

namespace InventoryFlow.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
        List<ProductDetailDto> GetProductDetailsByName(string key);
    }
}