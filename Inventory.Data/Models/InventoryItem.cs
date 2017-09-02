using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Data.Models
{
    public class InventoryItem
    {
        public int InventoryItemID { get; set; }
        public int InventoryCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PreviewImageUrl { get; set; }

        public InventoryCategory InventoryCategory { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
