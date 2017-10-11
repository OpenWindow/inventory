using Inventory.Entities;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Data
{
    public class InventoryContext : DbContext
    {
        public string ConnectionString { get; set; }

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        public DbSet<Category> InventoryCategories { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<ShoppingListItem> ShoppingListItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // overrider the table names created from DbSet Property names
            builder.Entity<Category>().ToTable("InventoryCategory");
            builder.Entity<InventoryItem>().ToTable("InventoryItem");
            builder.Entity<ShoppingListItem>().ToTable("ShoppingList");

        }

    }
}
