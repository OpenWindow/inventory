using Inventory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Data
{
    public static class DbInitializer
    {
        public static void Initialize(InventoryContext context)
        {
            context.Database.EnsureCreated();

            // Look for any inventory items
            if (context.Categories.Any())
            {
                return; // DB has been seeded
            }

            var categories = new Category[]
            {
                new Category { Name ="Kitchen", Description="all inventory in kitchen" },
                new Category { Name ="Living Room", Description="all inventory in living room" },
                new Category { Name ="Bed Rooms", Description="all inventory in all bed rooms" }
            };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var inventoryItems = new InventoryItem[]
            {
                new InventoryItem {
                    CategoryID = 1,
                    Name ="Wet Grinder",
                    Price =200.00,
                    PreviewImageUrl ="http://via.placeholder.com/150x150/ffffff/000000?text=wet+grinder",
                    PurchaseDate = DateTime.Parse("2005-09-01")},
                new InventoryItem {
                    CategoryID = 1,
                    Name ="Dining Table",
                    Price =100.00,
                    PreviewImageUrl ="http://via.placeholder.com/150x150/ffffff/000000?text=Dining+Table",
                    PurchaseDate = DateTime.Parse("2005-09-01")},
                new InventoryItem {
                    CategoryID = 1,
                    Name ="Rice Cooker",
                    Price =60.00,
                    PreviewImageUrl ="http://via.placeholder.com/150x150/ffffff/000000?text=rice+cooker",
                    PurchaseDate = DateTime.Parse("2005-09-01")},
                new InventoryItem {
                    CategoryID = 2,
                    Name ="Sofa",
                    Price =600.00,
                    PreviewImageUrl ="http://via.placeholder.com/150x150/ffffff/000000?text=sofa",
                    PurchaseDate = DateTime.Parse("2005-09-01")},
                new InventoryItem {
                    CategoryID = 2,
                    Name ="Samsung TV",
                    Price =1000.00,
                    PreviewImageUrl ="http://via.placeholder.com/150x150/ffffff/000000?text=Samsung+TV",
                    PurchaseDate = DateTime.Parse("2005-09-01")},
                new InventoryItem {
                    CategoryID = 2,
                    Name ="X-Arcade",
                    Price =160.00,
                    PreviewImageUrl ="http://via.placeholder.com/150x150/ffffff/000000?text=X-Arcade",
                    PurchaseDate = DateTime.Parse("2005-09-01")},
                new InventoryItem {
                    CategoryID = 3,
                    Name ="Mattress",
                    Price =500.00,
                    PreviewImageUrl ="http://via.placeholder.com/150x150/ffffff/000000?text=mattress",
                    PurchaseDate = DateTime.Parse("2005-09-01")},
                new InventoryItem {
                    CategoryID = 3,
                    Name ="Dressing Table",
                    Price =300.00,
                    PreviewImageUrl ="http://via.placeholder.com/150x150/ffffff/000000?text=Dressing+Table",
                    PurchaseDate = DateTime.Parse("2005-09-01")},
                new InventoryItem {
                    CategoryID = 3,
                    Name ="Bed",
                    Price =200.00,
                    PreviewImageUrl ="http://via.placeholder.com/150x150/ffffff/000000?text=bed",
                    PurchaseDate = DateTime.Parse("2005-09-01")}
            };

            foreach (InventoryItem item in inventoryItems)
            {
                context.InventoryItems.Add(item);
            }
            context.SaveChanges();

            var shoppingList = new ShoppingListItem[]
            {
                new ShoppingListItem { Name="Milk", Quantity=2, UnitOfMeasurement = UnitOfMeasurement.gallons},
                new ShoppingListItem { Name="Bread", Quantity=1, UnitOfMeasurement = UnitOfMeasurement.unit},
                new ShoppingListItem { Name="Oranges", Quantity=2, UnitOfMeasurement = UnitOfMeasurement.lbs},
                new ShoppingListItem { Name="Tomato", Quantity=2, UnitOfMeasurement = UnitOfMeasurement.lbs}
            };

            foreach(ShoppingListItem s in shoppingList)
            {
                context.ShoppingListItems.Add(s);
            }
            context.SaveChanges();
        }
    }
}
