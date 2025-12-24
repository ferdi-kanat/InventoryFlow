using System.Diagnostics.CodeAnalysis;
using InventoryFlow.Entities.Concrete;


namespace InventoryFlow.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}