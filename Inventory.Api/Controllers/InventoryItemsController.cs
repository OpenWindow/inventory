using Inventory.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Controllers
{
    [Route("api/categories")]
    public class InventoryItemsController : ControllerBase
    {
        private readonly InventoryContext _context;
        public InventoryItemsController(InventoryContext context)
        {
            this._context = context;
        }

        [HttpGet("{categoryId}/inventoryitems")]
        public IActionResult Get(int categoryId)
        {
            var category = this._context.InventoryCategories.FirstOrDefault(c => c.ID == categoryId);
            if(category == null)
            {
                return NotFound();
            }
            
            return Ok(category.InventoryItems);
        }

        [HttpGet("{categoryId}/inventoryitems/{itemId}")]
        public IActionResult GetInventoryItem(int categoryId, int itemId)
        {
            var category = _context.InventoryCategories.FirstOrDefault(c => c.ID == categoryId);
            if(category == null)
            {
                return NotFound();
            }

            var item = category.InventoryItems.FirstOrDefault(i => i.InventoryItemID == itemId);
            if(item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }


    }
}
