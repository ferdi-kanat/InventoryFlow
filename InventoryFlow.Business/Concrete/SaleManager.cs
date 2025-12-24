using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Utilities;
using InventoryFlow.Business.ValidationRules;
using InventoryFlow.DataAccess.Abstract;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;
using InventoryFlow.Business.Policies;

namespace InventoryFlow.Business.Concrete
{
    public class SaleManager : ISaleService
    {
        private ISaleDal _saleDal;
        private readonly IStockPolicy _stockPolicy;
        private readonly IPricingPolicy _pricingPolicy;
        private readonly ICustomerLinkPolicy _customerLinkPolicy;

        public SaleManager(ISaleDal saleDal, IStockPolicy stockPolicy, IPricingPolicy pricingPolicy, ICustomerLinkPolicy customerLinkPolicy)
        {
            _saleDal = saleDal;
            _stockPolicy = stockPolicy;
            _pricingPolicy = pricingPolicy;
            _customerLinkPolicy = customerLinkPolicy;
        }

        public void Add(Sale sale)
        {
            ArgumentNullException.ThrowIfNull(sale);

            ValidationTool.Validate(new SaleValidator(), sale);

            _customerLinkPolicy.ApplyCustomerLink(sale);

            var product = _stockPolicy.ReserveStock(sale);

            _pricingPolicy.ApplyPricing(sale, product);

            _saleDal.Add(sale);
        }

        public List<Sale> GetAll()
        {
            return _saleDal.GetAll();
        }

        public List<SaleDetailDto> GetSaleDetails()
        {
            return _saleDal.GetSaleDetails();
        }
    }
}