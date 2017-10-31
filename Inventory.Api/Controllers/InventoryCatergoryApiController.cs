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

    public class InventoryCatergoryApiController : ControllerBase
    {

        private readonly IMediator _mediator;

        public InventoryCatergoryApiController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        [Route("api/categories")]
        public async Task<IActionResult> Get(int page = -1, int pageSize = 15)
        {

            //TO DO: implement paging
            var categories = await _mediator.Send(new CategoriesQuery());
            return Ok(categories);
        }

        [HttpGet("api/categories/{id:int}", Name = "GetCategory")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _mediator.Send(new CategoryByCategoryIdQuery() { CategoryId = id });
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost("api/category")]
        public async Task<IActionResult> Create([FromBody] Category category)
        {

            //if (!ModelState.IsValid)
            //    throw new ApiException("Model binding failed.", 500);

            category.ID = await _mediator.Send(new EditCategoryCommand() { Category = category });

            if (category.ID > 0)
            {
                return CreatedAtRoute("GetCategory", new { id = category.ID }, category);
            }

            return BadRequest();
        }

        [HttpDelete("api/category/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteCategoryCommand() { CategoryId = id });

            return Ok();
        }
    }
}
