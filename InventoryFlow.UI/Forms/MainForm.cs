using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.DependencyResolvers;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;
using InventoryFlow.UI.Presentation;

namespace InventoryFlow.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly IProductService _productService;
        private readonly MainFormPresenter _presenter;
        public MainForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetProductService();
            _presenter = new MainFormPresenter(_productService);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            dgwProduct.DataSource = _presenter.LoadProducts();
        }

        private void btnOpenAddForm_Click(object sender, EventArgs e)
        {
            using var productForm = new ProductForm(_productService);
            productForm.ShowDialog();
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedProductDetail();
            if (selectedRow == null)
            {
                ShowInfo("Please select a product to update.");
                return;
            }

            Product? productToEdit = _productService.GetById(selectedRow.ProductId);
            if (productToEdit is null)
            {
                ShowError("Selected product could not be loaded.");
                return;
            }

            using (var productForm = new ProductForm(_productService, productToEdit))
            {
                productForm.ShowDialog();
            }
            LoadProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = GetSelectedProductDetail();
            if (selectedRow == null)
            {
                ShowInfo("Please select a product to delete.");
                return;
            }

            if (!ConfirmDeletion(selectedRow.ProductName))
            {
                return;
            }

            try
            {
                var result = _presenter.DeleteProduct(selectedRow);
                ShowResult(result);
                LoadProducts();
            }
            catch (Exception exception)
            {
                ShowError("Error: " + exception.Message);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchKey = tbxSearch.Text;
            dgwProduct.DataSource = _presenter.SearchProducts(searchKey);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.FileName = "InventoryReport.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var dataToExport = dgwProduct.DataSource as List<InventoryFlow.Entities.DTOs.ProductDetailDto>;
                        var result = MainFormPresenter.ExportProducts(dataToExport ?? new List<ProductDetailDto>(), sfd.FileName);
                        ShowResult(result);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during report: " + ex.Message);
                    }
                }
            }
        }

        private void btnOpenSales_Click(object sender, EventArgs e)
        {
            using (var salesForm = new SalesForm())
            {
                salesForm.ShowDialog();
            }
            LoadProducts();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            using (var customerForm = new CustomerForm())
            {
                customerForm.ShowDialog();
            }
        }

        private ProductDetailDto? GetSelectedProductDetail()
        {
            return dgwProduct.CurrentRow?.DataBoundItem as ProductDetailDto;
        }

        private static bool ConfirmDeletion(string productName)
        {
            var result = MessageBox.Show(
                $"Are you sure you want to delete '{productName}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            return result == DialogResult.Yes;
        }

        private static void ShowInfo(string message)
        {
            MessageBox.Show(message);
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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