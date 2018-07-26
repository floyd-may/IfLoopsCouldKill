using IfLoopsCouldKill.Details;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IfLoopsCouldKill
{
    public sealed class Example2Select
    {
        public IEnumerable<DateTime> GetOrderDates(IEnumerable<Order> orders)
        {
            var dates = new List<DateTime>();

            foreach(var order in orders)
            {
                dates.Add(order.Created);
            }

            return dates;
        }

        public IEnumerable<DateTime> GetOrderDates2(IEnumerable<Order> orders)
        {
            return orders.Select(x => x.Created);
        }
    }
}
