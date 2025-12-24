using System.Globalization;
using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Utilities;
using InventoryFlow.Business.ValidationRules;
using InventoryFlow.DataAccess.Abstract;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;

namespace InventoryFlow.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ArgumentNullException.ThrowIfNull(product);

            ValidationTool.Validate(new ProductValidator(), product);
            product.AddedDate = DateTime.Now;
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Deletion failed!", ex);
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public Product? GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public List<ProductDetailDto> GetProductDetailsByName(string key)
        {
            return _productDal.GetProductDetailsByName(key);
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string key)
        {
            return _productDal.GetAll(p => p.Name.Contains(key, StringComparison.OrdinalIgnoreCase));
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}