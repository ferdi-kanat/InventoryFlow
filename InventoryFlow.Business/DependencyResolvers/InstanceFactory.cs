using System.Diagnostics.CodeAnalysis;
using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Concrete;
using InventoryFlow.Business.Policies;
using InventoryFlow.DataAccess.Concrete.EntityFramework;

namespace InventoryFlow.Business.DependencyResolvers
{
    public static class InstanceFactory
    {
        // This method gives the UI a fully prepared ProductManager
        // without the UI needing to know about EfProductDal.
        public static IProductService GetProductService()
        {
            return new ProductManager(new EfProductDal());
        }

        public static ICategoryService GetCategoryService()
        {
            return new CategoryManager(new EfCategoryDal());
        }

        public static ISaleService GetSaleService()
        {
            var productService = GetProductService();

            var stockPolicy = new StockPolicy(productService);
            var pricingPolicy = new PricingPolicy();
            var customerLinkPolicy = new CustomerLinkPolicy();

            return new SaleManager(new EfSaleDal(), stockPolicy, pricingPolicy, customerLinkPolicy);
        }

        public static ICustomerService GetCustomerService()
        {
            return new CustomerManager(new EfCustomerDal());
        }
    }
}