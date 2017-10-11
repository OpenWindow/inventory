using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Entities
{
    public class InventoryItem : IEntityBase
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PreviewImageUrl { get; set; }

        public Category Category { get; set; }
    }
}
