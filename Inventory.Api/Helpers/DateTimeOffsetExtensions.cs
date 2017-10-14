using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventory.Api.Helpers
{
    public static class DateTimeOffsetExtensions
    {
		public static int GetDaysAgo(this DateTimeOffset dateTimeOffset)
        {
            return (DateTime.UtcNow - dateTimeOffset).Days;
        }
    }
}
