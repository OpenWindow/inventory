using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Features.InventoryItems
{
    public class InventoryItemByInventoryItemIdQuery : IRequest<Entities.InventoryItem>
    {
        public int InventoryItemId { get; set; }
    }
}
