using System.Linq.Expressions;
using InventoryFlow.DataAccess.Abstract;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;

namespace InventoryFlow.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, InventoryContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (InventoryContext context = new InventoryContext())
            {
                return BaseProductQuery(context)
                    .Select(SelectProductDetailDto)
                    .ToList();
            }
        }

        public List<ProductDetailDto> GetProductDetailsByName(string key)
        {
            using (InventoryContext context = new InventoryContext())
            {
                return BaseProductQuery(context)
                    .Where(ByName(key))
                    .Select(SelectProductDetailDto)
                    .ToList();
            }
        }

        private static IQueryable<ProductJoinRow> BaseProductQuery(InventoryContext context)
        {
            return context.Products
                .Join(context.Categories,
                      p => p.CategoryId,
                      c => c.Id,
                      (product, category) => new ProductJoinRow
                      {
                          Product = product,
                          Category = category
                      });
        }

        private static Expression<Func<ProductJoinRow, bool>> ByName(string key)
        {
            return row => row.Product.Name.Contains(key);
        }

        private static ProductDetailDto SelectProductDetailDto(ProductJoinRow row)
        {
            return new ProductDetailDto
            {
                ProductId = row.Product.Id,
                ProductName = row.Product.Name,
                CategoryName = row.Category.Name,
                UnitPrice = row.Product.UnitPrice,
                StockAmount = row.Product.StockAmount
            };
        }

        private sealed class ProductJoinRow
        {
            public required Product Product { get; init; }
            public required Category Category { get; init; }
        }
    }
}