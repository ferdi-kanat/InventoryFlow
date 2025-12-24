using InventoryFlow.Business.Abstract;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;
using InventoryFlow.UI.Reports;
using System.IO;
using System.Linq;

namespace InventoryFlow.UI.Presentation
{
    public class MainFormPresenter
    {
        private readonly IProductService _productService;

        public MainFormPresenter(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public List<ProductDetailDto> LoadProducts()
        {
            return _productService.GetProductDetails();
        }

        public List<ProductDetailDto> SearchProducts(string key)
        {
            ArgumentNullException.ThrowIfNull(key);

            return string.IsNullOrWhiteSpace(key)
                ? LoadProducts()
                : _productService.GetProductDetailsByName(key);
        }

        public FormActionResult DeleteProduct(ProductDetailDto selectedRow)
        {
            ArgumentNullException.ThrowIfNull(selectedRow);

            try
            {
                _productService.Delete(new Product { Id = selectedRow.ProductId });
                return FormActionResult.Ok("Product deleted.");
            }
            catch (InvalidOperationException exception)
            {
                return FormActionResult.Fail("Error: " + exception.Message);
            }
            catch (ArgumentException exception)
            {
                return FormActionResult.Fail("Error: " + exception.Message);
            }
        }

        public static FormActionResult ExportProducts(IEnumerable<ProductDetailDto> data, string filePath)
        {
            ArgumentNullException.ThrowIfNull(data);
            ArgumentNullException.ThrowIfNull(filePath);

            var products = data.ToList();

            if (products.Count == 0)
            {
                return FormActionResult.Fail("No data to export!", "Warning");
            }

            try
            {
                ExcelReporter.ExportProducts(products, filePath);
                return FormActionResult.Ok("Products exported successfully!");
            }
            catch (IOException ex)
            {
                return FormActionResult.Fail("Error during report: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return FormActionResult.Fail("Error during report: " + ex.Message);
            }
        }
    }
}
