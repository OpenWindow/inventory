using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Features.ShopingListItems
{
    public class ShoppingListItemsPurchasedQuery : IRequest<List<Entities.ShoppingListItem>>
    {
    }
}
