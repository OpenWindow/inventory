using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Models
{
    public class InventoryCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();

        public byte[] RowVersion { get; set; }
    }
}
