using InventoryFlow.DataAccess.Abstract;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace InventoryFlow.DataAccess.Concrete.EntityFramework
{
    public class EfSaleDal : EfEntityRepositoryBase<Sale, InventoryContext>, ISaleDal
    {
        public List<SaleDetailDto> GetSaleDetails()
        {
            using (InventoryContext context = new InventoryContext())
            {
                return BaseSaleQuery(context)
                    .Select(SelectSaleDetailDto)
                    .ToList();
            }
        }

        private static IQueryable<SaleJoinRow> BaseSaleQuery(InventoryContext context)
        {
            var sales = context.Sales.AsNoTracking();
            var products = context.Products.AsNoTracking();
            var categories = context.Categories.AsNoTracking();
            var customers = context.Customers.AsNoTracking();

            return sales
                .Join(products, s => s.ProductId, p => p.Id, (sale, product) => new { sale, product })
                .Join(categories, sp => sp.product.CategoryId, c => c.Id, (sp, category) => new { sp.sale, sp.product, category })
                .GroupJoin(customers, spc => spc.sale.CustomerId, cust => cust.Id, (spc, custs) => new { spc.sale, spc.product, spc.category, custs })
                .SelectMany(x => x.custs.DefaultIfEmpty(), (x, customer) => new SaleJoinRow
                {
                    Sale = x.sale,
                    Product = x.product,
                    Category = x.category,
                    Customer = customer
                });
        }

        private static SaleDetailDto SelectSaleDetailDto(SaleJoinRow row)
        {
            return new SaleDetailDto
            {
                SaleId = row.Sale.Id,
                ProductName = row.Product.Name,
                CategoryName = row.Category.Name,
                CustomerName = row.Customer == null ? "Walk-in Customer" : row.Customer.FirstName + " " + row.Customer.LastName,
                Quantity = row.Sale.Quantity,
                UnitPrice = row.Product.UnitPrice,
                TotalPrice = row.Sale.TotalPrice,
                Date = row.Sale.Date
            };
        }

        private sealed class SaleJoinRow
        {
            public required Sale Sale { get; init; }
            public required Product Product { get; init; }
            public required Category Category { get; init; }
            public Customer? Customer { get; init; }
        }
    }
}