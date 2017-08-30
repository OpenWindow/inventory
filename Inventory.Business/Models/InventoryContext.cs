using Microsoft.EntityFrameworkCore;
using System;

namespace Inventory.Business.Models
{
    public class InventoryContext : DbContext
    {
        public string ConnectionString { get; set; }

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {

        }

        public DbSet<InventoryItem> InventoryItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
