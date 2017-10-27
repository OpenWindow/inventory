using Inventory.Entities;
using MediatR;
using System.Collections.Generic;

namespace Inventory.Api.Features.Categories
{
    public class CategoriesQuery: IRequest<IEnumerable<Category>>
    {

    }
}
