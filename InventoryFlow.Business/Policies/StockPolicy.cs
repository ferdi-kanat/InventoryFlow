using InventoryFlow.Business.Abstract;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Policies
{
    public class StockPolicy : IStockPolicy
    {
        private readonly IProductService _productService;

        public StockPolicy(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public Product ReserveStock(Sale sale)
        {
            ArgumentNullException.ThrowIfNull(sale);

            var product = _productService.GetById(sale.ProductId);

            if (product == null)
            {
                throw new InvalidOperationException("Product not found!");
            }

            if (product.StockAmount < sale.Quantity)
            {
                throw new InvalidOperationException($"Not enough stock! Current stock: {product.StockAmount}");
            }

            product.StockAmount -= sale.Quantity;
            _productService.Update(product);

            return product;
        }
    }
}
