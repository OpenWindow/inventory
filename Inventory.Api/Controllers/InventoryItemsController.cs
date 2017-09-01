using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Controllers
{
    [Route("api/[controller]")]
    public class InventoryItemsController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(new { Name = "Neel", FavoriteColor = "Blue" });
        }


    }
}
