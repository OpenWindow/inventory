using Inventory.Api.Extensions;
using Inventory.Data;
using Inventory.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Features.Categories
{
    public class EditCategoryCommandHandler : IAsyncRequestHandler<EditCategoryCommand, int>
    {
        private InventoryContext _context;

        public EditCategoryCommandHandler(InventoryContext context)
        {
            this._context = context;
        }

        async Task<int> IAsyncRequestHandler<EditCategoryCommand, int>.Handle(EditCategoryCommand message)
        {
            var category = await GetCategory(message) ?? new Category();
            category.Name = message.Category.Name;
            category.Description = message.Category.Description;

            _context.AddOrUpdate(category);
            await _context.SaveChangesAsync();

            return category.ID;
        }

        private async Task<Category> GetCategory(EditCategoryCommand message)
        {
            return await _context.Categories.SingleOrDefaultAsync(c => c.ID == message.Category.ID);
        }
    }
}
