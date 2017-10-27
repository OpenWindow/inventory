using Inventory.Data;
using Inventory.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Inventory.Api.Features.Categories
{
    public class CategoryByCategoryIdQueryHandler : IAsyncRequestHandler<CategoryByCategoryIdQuery, Category>
    {
        private readonly InventoryContext _context;

        public CategoryByCategoryIdQueryHandler(InventoryContext context)
        {
            this._context = context;
        }

        public async Task<Category> Handle(CategoryByCategoryIdQuery message)
        {
            return await _context.Categories.SingleOrDefaultAsync(c => c.ID == message.CategoryId);
        }
    }
}
