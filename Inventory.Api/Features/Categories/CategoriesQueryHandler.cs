using Inventory.Data;
using Inventory.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventory.Api.Features.Categories
{
    public class CategoriesQueryHandler : IAsyncRequestHandler<CategoriesQuery, IEnumerable<Category>>
    {
        private InventoryContext _context;
        public CategoriesQueryHandler(InventoryContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Category>> Handle(CategoriesQuery message)
        {
            return await _context.Categories.ToListAsync();
        }
      
    }
}
