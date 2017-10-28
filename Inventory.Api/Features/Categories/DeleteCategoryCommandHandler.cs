using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Inventory.Data;

namespace Inventory.Api.Features.Categories
{
    public class DeleteCategoryCommandHandler : IAsyncRequestHandler<DeleteCategoryCommand, bool>
    {
        private readonly InventoryContext _context;

        public DeleteCategoryCommandHandler(InventoryContext context)
        {
            this._context = context;
        }

        public async Task<bool> Handle(DeleteCategoryCommand message)
        {
            var category = _context.Categories.SingleOrDefault(c => c.ID == message.CategoryId);

            if(category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }

            return true;
        }
    }
}
