using AutoMapper;
using Inventory.Api.Dto;
using Inventory.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Controllers
{
    [Route("api/categories")]
    public class InventoryItemsApiController : ControllerBase
    {
        private readonly InventoryContext _context;
        public InventoryItemsApiController(InventoryContext context)
        {
            this._context = context;
        }

        [HttpGet("{categoryId}/inventoryitems")]
        public IActionResult Get(int categoryId)
        {
            var categoryFromRepo = this._context.Categories.FirstOrDefault(c => c.ID == categoryId);
            if(categoryFromRepo == null)
            {
                return NotFound();
            }

            var itemsFromRepo = categoryFromRepo.InventoryItems;
            var items = Mapper.Map<IEnumerable<InventoryItemDto>>(itemsFromRepo);
            
            return Ok(items);
        }

        [HttpGet("{categoryId}/inventoryitems/{itemId}")]
        public IActionResult GetInventoryItem(int categoryId, int itemId)
        {
            var category = _context.Categories.FirstOrDefault(c => c.ID == categoryId);
            if(category == null)
            {
                return NotFound();
            }

            var itemFromRepo = category.InventoryItems.FirstOrDefault(i => i.ID == itemId);
            if(itemFromRepo == null)
            {
                return NotFound();
            }

            var item = Mapper.Map<InventoryItemDto>(itemFromRepo);
            return Ok(item);
        }


    }
}
