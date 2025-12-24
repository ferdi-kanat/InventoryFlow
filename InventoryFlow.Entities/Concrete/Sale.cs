using InventoryFlow.Entities.Abstract;

namespace InventoryFlow.Entities.Concrete
{
    public class Sale : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; } // Foreign key
        public int? CustomerId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; } // Quantity * UnitPrice
        public DateTime Date { get; set; } = DateTime.Now;
    }
}