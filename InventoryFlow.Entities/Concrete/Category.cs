using InventoryFlow.Entities.Abstract;

namespace InventoryFlow.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}