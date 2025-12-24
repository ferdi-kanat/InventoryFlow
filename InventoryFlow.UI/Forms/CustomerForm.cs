using System.Globalization;
using FluentValidation;
using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.DependencyResolvers;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.UI.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly ICustomerService _customerService;
        public CustomerForm()
        {
            InitializeComponent();
            _customerService = InstanceFactory.GetCustomerService();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgwCustomers.DataSource = _customerService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.Add(new Customer
                {
                    FirstName = tbxFirstName.Text,
                    LastName = tbxLastName.Text,
                    Email = tbxEmail.Text,
                    Phone = tbxPhone.Text
                });

                MessageBox.Show("Customer added!");
                LoadCustomers();
                ClearInputs();
            }
            catch (ValidationException ex)
            {
                ShowError(ex.Message, "Validation Error");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCustomer = GetSelectedCustomer();
                if (selectedCustomer == null)
                {
                    ShowInfo("Please select a customer to update.");
                    return;
                }

                var customer = new Customer
                {
                    Id = selectedCustomer.Id,
                    FirstName = tbxFirstName.Text,
                    LastName = tbxLastName.Text,
                    Email = tbxEmail.Text,
                    Phone = tbxPhone.Text,
                    RegisteredDate = selectedCustomer.RegisteredDate
                };

                _customerService.Update(customer);
                ShowInfo("Customer updated!");
                LoadCustomers();
                ClearInputs();
            }
            catch (ValidationException ex)
            {
                ShowError(ex.Message, "Validation Error");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCustomer = GetSelectedCustomer();
                if (selectedCustomer == null)
                {
                    ShowInfo("Please select a customer to delete.");
                    return;
                }

                _customerService.Delete(new Customer { Id = selectedCustomer.Id });

                ShowInfo("Customer deleted!");
                LoadCustomers();
                ClearInputs();
            }
            catch (ValidationException ex)
            {
                ShowError(ex.Message, "Validation Error");
            }
        }

        private void dgwCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwCustomers.CurrentRow != null)
            {
                tbxFirstName.Text = dgwCustomers.CurrentRow.Cells["FirstName"].Value.ToString();
                tbxLastName.Text = dgwCustomers.CurrentRow.Cells["LastName"].Value.ToString();
                tbxEmail.Text = dgwCustomers.CurrentRow.Cells["Email"].Value.ToString();
                tbxPhone.Text = dgwCustomers.CurrentRow.Cells["Phone"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxEmail.Clear();
            tbxPhone.Clear();
        }

        private Customer? GetSelectedCustomer()
        {
            return dgwCustomers.CurrentRow?.DataBoundItem as Customer;
        }

        private static void ShowInfo(string message)
        {
            MessageBox.Show(message);
        }

        private static void ShowError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}