using System.Globalization;
using FluentValidation;
using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Commands;
using InventoryFlow.Business.DependencyResolvers;
using InventoryFlow.Business.Handlers;
using InventoryFlow.Entities.DTOs;
using InventoryFlow.UI.Presentation;

namespace InventoryFlow.UI.Forms
{
    public partial class SalesForm : Form
    {
        private readonly SalesFormPresenter _presenter;

        public SalesForm()
        {
            InitializeComponent();
            var saleService = InstanceFactory.GetSaleService();
            var sellHandler = new SellProductCommandHandler(saleService);
            var productService = InstanceFactory.GetProductService();
            var customerService = InstanceFactory.GetCustomerService();
            _presenter = new SalesFormPresenter(sellHandler, saleService, productService, customerService);
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            cbxProducts.DataSource = _presenter.LoadProducts();
            cbxProducts.DisplayMember = "Name";
            cbxProducts.ValueMember = "Id";
            LoadCustomers();
            LoadSalesHistory();
        }

        private void LoadCustomers()
        {
            cbxCustomers.DataSource = _presenter.LoadCustomersWithWalkIn();
            cbxCustomers.DisplayMember = "FirstName";
            cbxCustomers.ValueMember = "Id";
        }

        private void LoadSalesHistory()
        {
            var salesList = _presenter.LoadSalesDetails();
            dgwSalesHistory.DataSource = salesList;
            CalculateTotalRevenue(salesList);
        }

        private void CalculateTotalRevenue(List<SaleDetailDto> sales)
        {
            var total = SalesFormPresenter.CalculateTotalRevenue(sales);
            lblTotalRevenue.Text = "Total Revenue: " + total.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            ExecuteSell();
        }

        private void ExecuteSell()
        {
            try
            {
                var command = BuildSellCommand();

                var result = _presenter.ExecuteSale(command);
                ShowResult(result);

                if (result.Success)
                {
                    tbxQuantity.Clear();
                    LoadSalesHistory();
                }
            }
            catch (ValidationException ex)
            {
                ShowResult(FormActionResult.Fail(ex.Message, "Sale Failed"));
            }
        }

        private SellProductCommand BuildSellCommand()
        {
            var quantity = ParseQuantity(tbxQuantity.Text);
            var productId = ParseRequiredSelection(cbxProducts.SelectedValue, "product");
            var customerId = ParseOptionalCustomerSelection(cbxCustomers.SelectedValue);

            return new SellProductCommand
            {
                ProductId = productId,
                Quantity = quantity,
                CustomerId = customerId
            };
        }

        private static int ParseQuantity(string? quantityText)
        {
            if (string.IsNullOrWhiteSpace(quantityText) || !int.TryParse(quantityText, NumberStyles.Integer, CultureInfo.InvariantCulture, out var quantity))
            {
                throw new ValidationException("Please enter a valid number for quantity.");
            }

            return quantity;
        }

        private static int ParseRequiredSelection(object? value, string fieldName)
        {
            if (!TryGetSelectedId(value, out var id) || id <= 0)
            {
                throw new ValidationException($"Please select a {fieldName}.");
            }

            return id;
        }

        private static int? ParseOptionalCustomerSelection(object? value)
        {
            if (!TryGetSelectedId(value, out var id))
            {
                throw new ValidationException("Please select a customer.");
            }

            return id == 0 ? null : id;
        }

        private static bool TryGetSelectedId(object? value, out int id)
        {
            try
            {
                id = Convert.ToInt32(value, CultureInfo.InvariantCulture);
                return true;
            }
            catch (Exception)
            {
                id = default;
                return false;
            }
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