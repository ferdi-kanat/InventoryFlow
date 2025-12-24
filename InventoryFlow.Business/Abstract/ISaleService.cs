using System.Diagnostics.CodeAnalysis;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;

namespace InventoryFlow.Business.Abstract
{
    public interface ISaleService
    {
        void Add(Sale sale);
        List<Sale> GetAll();
        List<SaleDetailDto> GetSaleDetails();
    }
}