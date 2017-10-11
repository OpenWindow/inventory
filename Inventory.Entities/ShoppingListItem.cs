using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Entities
{
    public enum UnitOfMeasurement
    {
        none,
        lbs,
        gallons,
        oz,
        kgs,
        @case,
        unit
    }

    public class ShoppingListItem : IEntityBase
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public UnitOfMeasurement? UnitOfMeasurement { get; set; }
        public string Description { get; set; }
    }
}
