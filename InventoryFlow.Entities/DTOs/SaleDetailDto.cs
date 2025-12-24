namespace InventoryFlow.Entities.DTOs
{
    public class SaleDetailDto
    {
        public int SaleId { get; set; }
        public string ProductName { get; set; } = string.Empty; // We want the NAME, not the ID
        public string CategoryName { get; set; } = string.Empty; // Let's show Category too
        public string CustomerName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}