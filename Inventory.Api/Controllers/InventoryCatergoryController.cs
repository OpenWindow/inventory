using AutoMapper;
using Inventory.Api.Dto;
using Inventory.Api.Features.Categories;
using Inventory.Data;
using Inventory.Entities;
using MediatR;
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

        private readonly IMediator _mediator;

        public InventoryCatergoryController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet("")]
        public async  Task<IActionResult> Get(int page = -1, int pageSize = 15)
        {

            //TO DO: implement paging
            var categories = await _mediator.Send(new CategoriesQuery());
            return Ok(categories);
        }

        [HttpGet("{id}", Name = "GetCategory")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _mediator.Send(new CategoryByCategoryIdQuery() { CategoryId = id });
            if(category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Category category)
        {
            if (category == null)
                return BadRequest();

            var id = await _mediator.Send(new EditCategoryCommand() { Category = category });

            if (id > 0)
            {
                return CreatedAtRoute("GetCategory", new { id = id }, category);
            }

            return BadRequest();
        }

    }
}
