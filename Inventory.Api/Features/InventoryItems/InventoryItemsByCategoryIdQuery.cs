using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Features.InventoryItems
{
    public class InventoryItemsByCategoryIdQuery: IRequest<List<Entities.InventoryItem>>
    {
        public int CategoryId { get; set; }
    }
}
