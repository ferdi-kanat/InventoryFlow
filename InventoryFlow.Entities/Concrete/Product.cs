using InventoryFlow.Entities.Abstract;

namespace InventoryFlow.Entities.Concrete
{
    public class Product : IEntity
    {
        // [Key] is optional if the property name is "Id", but good for clarity
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        // We use decimal for money to avoid rounding errors (double is bad for money)
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
        public int CategoryId { get; set; }
        // Useful for tracking when the product was added
        public DateTime AddedDate { get; set; } = DateTime.Now;
    }
}