using System.Diagnostics.CodeAnalysis;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;

namespace InventoryFlow.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByProductName(string key);
        List<ProductDetailDto> GetProductDetails();
        List<ProductDetailDto> GetProductDetailsByName(string key);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product? GetById(int id);
    }
}