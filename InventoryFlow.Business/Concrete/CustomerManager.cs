using InventoryFlow.Business.Abstract;
using InventoryFlow.Business.Utilities;
using InventoryFlow.Business.ValidationRules;
using InventoryFlow.DataAccess.Abstract;
using InventoryFlow.Entities.Concrete;

namespace InventoryFlow.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            ArgumentNullException.ThrowIfNull(customer);

            ValidationTool.Validate(new CustomerValidator(), customer);
            customer.RegisteredDate = DateTime.Now;
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public void Update(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Update(customer);
        }
    }
}