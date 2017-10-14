using Inventory.Entities;

namespace Inventory.Api.Dto
{
    public class ShoppingListItemDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public UnitOfMeasurement? UnitOfMeasurement { get; set; }
        public string Description { get; set; }
    }
}
