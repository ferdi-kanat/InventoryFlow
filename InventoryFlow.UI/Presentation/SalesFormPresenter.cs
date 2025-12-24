using FluentValidation;
using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Commands;
using InventoryFlow.Business.Handlers;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;
using System.Linq;

namespace InventoryFlow.UI.Presentation
{
    public class SalesFormPresenter
    {
        private readonly SellProductCommandHandler _sellHandler;
        private readonly ISaleService _saleService;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;

        public SalesFormPresenter(SellProductCommandHandler sellHandler, ISaleService saleService, IProductService productService, ICustomerService customerService)
        {
            _sellHandler = sellHandler ?? throw new ArgumentNullException(nameof(sellHandler));
            _saleService = saleService ?? throw new ArgumentNullException(nameof(saleService));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        public List<Product> LoadProducts()
        {
            return _productService.GetAll();
        }

        public List<Customer> LoadCustomersWithWalkIn()
        {
            var customers = _customerService.GetAll();
            customers.Insert(0, new Customer { Id = 0, FirstName = "Walk-in", LastName = "Customer" });
            return customers;
        }

        public List<SaleDetailDto> LoadSalesDetails()
        {
            return _saleService.GetSaleDetails();
        }

        public static decimal CalculateTotalRevenue(IEnumerable<SaleDetailDto> sales)
        {
            ArgumentNullException.ThrowIfNull(sales);
            return sales.Sum(s => s.TotalPrice);
        }

        public FormActionResult ExecuteSale(SellProductCommand command)
        {
            try
            {
                _sellHandler.Handle(command);
                return FormActionResult.Ok("Sale successful!");
            }
            catch (ValidationException ex)
            {
                return FormActionResult.Fail(ex.Message, "Sale Failed");
            }
            catch (InvalidOperationException ex)
            {
                return FormActionResult.Fail(ex.Message, "Sale Failed");
            }
        }
    }
}
