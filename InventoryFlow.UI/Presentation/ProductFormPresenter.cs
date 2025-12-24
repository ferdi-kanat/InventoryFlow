using FluentValidation;
using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Commands;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.UI.Presentation
{
    public class ProductFormPresenter
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductFormPresenter(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
        }

        public List<Category> LoadCategories()
        {
            return _categoryService.GetAll();
        }

        public FormActionResult Save(AddProductCommand command, Product? existing)
        {
            ArgumentNullException.ThrowIfNull(command);

            try
            {
                var product = command.ToProduct(existing);

                if (existing == null)
                {
                    _productService.Add(product);
                    return FormActionResult.Ok("Product added successfully!");
                }

                _productService.Update(product);
                return FormActionResult.Ok("Product updated successfully!");
            }
            catch (ValidationException ex)
            {
                return FormActionResult.Fail(ex.Message, "Validation Error");
            }
            catch (InvalidOperationException ex)
            {
                return FormActionResult.Fail(ex.Message, "Error");
            }
            catch (ArgumentException ex)
            {
                return FormActionResult.Fail(ex.Message, "Error");
            }
        }
    }
}
