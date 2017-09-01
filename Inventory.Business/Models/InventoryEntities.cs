using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Business.Models
{
    public class InventoryCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<InventoryItem> InventoryItems { get; set; }

        public byte[] RowVersion { get; set; }
    }

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

    public enum UnitOfMeasurement
    {
        none, lbs, gallons, oz, kgs, @case, unit
    }

    public class ShoppingListItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public UnitOfMeasurement? UnitOfMeasurement { get; set; }
        public string Description { get; set; }

        public byte[] RowVersion { get; set; }
    }
}
