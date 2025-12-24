using InventoryFlow.Entities.Abstract;

namespace InventoryFlow.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime RegisteredDate { get; set; }
    }
}