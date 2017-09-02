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
    [Route("api/[controller]")]
    public class InventoryCatergoryController : ControllerBase
    {

        private readonly InventoryContext _context;

        //public InventoryCatergoryController(InventoryContext context)
        //{
        //    this._context = context;
        //}

        //[HttpGet("")]
        //public async Task<IEnumerable<InventoryCategory>> Get(int page = -1, int pageSize = 15)
        //{
        //    return Ok();
        //}
    }
}
