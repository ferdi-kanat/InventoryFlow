using System.Globalization;
using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Commands;
using InventoryFlow.Business.DependencyResolvers;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.UI.Presentation;

namespace InventoryFlow.UI.Forms
{
    public partial class ProductForm : Form
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly Product? _productToUpdate;
        private readonly ProductFormPresenter _presenter;

        public ProductForm(IProductService productService, Product? product = null)
        {
            InitializeComponent();
            _productService = productService;
            _productToUpdate = product;
            _categoryService = InstanceFactory.GetCategoryService();
            _presenter = new ProductFormPresenter(_productService, _categoryService);
        }

        private void LoadCategories()
        {
            var categories = _presenter.LoadCategories();
            cbxCategory.DataSource = categories;
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            if (_productToUpdate != null)
            {
                btnAdd.Text = "Update Product";
                tbxProductName.Text = _productToUpdate.Name;
                tbxUnitPrice.Text = _productToUpdate.UnitPrice.ToString(CultureInfo.CurrentCulture);
                tbxStockAmount.Text = _productToUpdate.StockAmount.ToString(CultureInfo.CurrentCulture);
                cbxCategory.SelectedValue = _productToUpdate.CategoryId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var command = new AddProductCommand
            {
                Id = _productToUpdate?.Id,
                Name = tbxProductName.Text,
                UnitPriceText = tbxUnitPrice.Text,
                StockAmountText = tbxStockAmount.Text,
                CategoryValue = cbxCategory.SelectedValue
            };

            var result = _presenter.Save(command, _productToUpdate);
            ShowResult(result);

            if (result.Success)
            {
                Close();
            }
        }

        private static void ShowInfo(string message)
        {
            MessageBox.Show(message);
        }

        private static void ShowError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ShowResult(FormActionResult result)
        {
            if (result.Success)
            {
                MessageBox.Show(result.Message, result.Title);
                return;
            }

            MessageBox.Show(result.Message, result.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}