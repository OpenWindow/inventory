using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Entities
{
    public class Category : IEntityBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();
    }
}
