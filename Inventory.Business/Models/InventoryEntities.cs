using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Business.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PreviewImageUrl { get; set; }
    }
}
