using Inventory.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Data.Models;

namespace Inventory.Api.Controllers
{
    [Route("api/categories")]
    public class InventoryCatergoryController : ControllerBase
    {

        private readonly InventoryContext _context;

        public InventoryCatergoryController(InventoryContext context)
        {
            this._context = context;
        }

        [HttpGet("")]
        public IActionResult Get(int page = -1, int pageSize = 15)
        {

            //TO DO: implement paging
            return Ok(_context.InventoryCategories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var category = _context.InventoryCategories.FirstOrDefault(c => c.ID == id);
            if(category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }
    }
}
