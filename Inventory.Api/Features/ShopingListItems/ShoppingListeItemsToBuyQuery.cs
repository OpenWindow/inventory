using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Features.ShopingListItems
{
    public class ShoppingListeItemsToBuyQuery : IRequest<List<Entities.ShoppingListItem>>
    {
    }
}
