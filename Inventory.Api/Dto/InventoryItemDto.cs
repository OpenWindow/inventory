using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Dto
{
    public class InventoryItemDto
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int PurchasedDaysAgo { get; set; }
        public DateTimeOffset PurchaseDate { get; set; }
        public string PreviewImageUrl { get; set; }
    }
}
