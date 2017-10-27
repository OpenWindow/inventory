using Inventory.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Features.Categories
{
    public class EditCategoryCommand : IRequest<int>
    {
        public Category Category { get; set; }
    }
}
