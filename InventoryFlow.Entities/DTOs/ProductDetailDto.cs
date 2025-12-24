namespace InventoryFlow.Entities.DTOs
{
    public class ProductDetailDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}