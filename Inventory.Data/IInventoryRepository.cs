using Inventory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public interface IInventoryRepository
    {
        // Basic DB operations
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAllSync();

        // Categories
        IEnumerable<Category> GetAllCategories();
        Category GetInventoryCategory(int id);

        // Inventory Items
        IEnumerable<InventoryItem> GetAllInventoryItems();
        InventoryItem GetInventoryItem(int id);
        IEnumerable<InventoryItem> GetInventoryItemsByCategory(int categoryId);

        // Shopping List Items
        IEnumerable<ShoppingListItem> GetAllShoppingList();
        ShoppingListItem GetShoppingListItem(int id);


    }

    public interface IRepository<T>
    {
        void Add(T newEntity);
        void Remove(T entity);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        IQueryable<T> FindAll();
        T FindById(int id);
    }
}
