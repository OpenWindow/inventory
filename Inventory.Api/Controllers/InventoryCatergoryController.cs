using AutoMapper;
using Inventory.Api.Dto;
using Inventory.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var categoriesFromRepo = _context.Categories;
            var categories = Mapper.Map<IEnumerable<CategoryDto>>(categoriesFromRepo);

            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var categoryFromRepo = _context.Categories.FirstOrDefault(c => c.ID == id);
            if(categoryFromRepo == null)
            {
                return NotFound();
            }

            var category = Mapper.Map<CategoryDto>(categoryFromRepo);
            return Ok(category);
        }
    }
}
