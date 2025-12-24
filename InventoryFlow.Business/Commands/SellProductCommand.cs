using System.Diagnostics.CodeAnalysis;

namespace InventoryFlow.Business.Commands
{
    public class SellProductCommand
    {
        [SuppressMessage("Usage", "CA2227", Justification = "Command properties are set at creation time.")]
        public int ProductId { get; set; }

        [SuppressMessage("Usage", "CA2227", Justification = "Command properties are set at creation time.")]
        public int Quantity { get; set; }

        [SuppressMessage("Usage", "CA2227", Justification = "Command properties are set at creation time.")]
        public int? CustomerId { get; set; }
    }
}
