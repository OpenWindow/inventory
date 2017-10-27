using Inventory.Entities;
using MediatR;

namespace Inventory.Api.Features.Categories
{
    public class CategoryByCategoryIdQuery : IRequest<Category>
    {
        public int CategoryId { get; set; }
    }
}
