using System.Diagnostics.CodeAnalysis;
using InventoryFlow.Entities.Concrete;
using InventoryFlow.Entities.DTOs;

namespace InventoryFlow.DataAccess.Abstract
{
    public interface ISaleDal : IEntityRepository<Sale>
    {
        List<SaleDetailDto> GetSaleDetails();
    }
}