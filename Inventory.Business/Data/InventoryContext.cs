using Inventory.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Business.Data
{
    public class InventoryContext : DbContext
    {
        public string ConnectionString { get; set; }

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        public DbSet<InventoryCategory> InventoryCategory { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<ShoppingListItem> ShoppingListItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // overrider the table names created from DbSet Property names
            builder.Entity<InventoryCategory>().ToTable("InventoryCategory");
            builder.Entity<InventoryItem>().ToTable("InventoryItem");
            builder.Entity<ShoppingListItem>().ToTable("ShoppingList");

        }

    }
}
