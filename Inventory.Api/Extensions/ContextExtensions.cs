using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Extensions
{
    public static class ContextExtensions
    {
        public static void AddOrUpdate(this DbContext context, object entity)
        {
            var entry = context.Entry(entity);

            switch (entry.State)
            {
                case EntityState.Detached:
                    context.Add(entity);
                    break;
                case EntityState.Modified:
                    context.Update(entity);
                    break;
                case EntityState.Added:
                    context.Add(entity);
                    break;
                case EntityState.Unchanged:
                    break;

                default:
                    throw new ArgumentNullException();

            }
        }
    }
}
