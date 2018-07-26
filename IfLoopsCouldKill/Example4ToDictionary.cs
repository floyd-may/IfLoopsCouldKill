using IfLoopsCouldKill.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfLoopsCouldKill
{
    public sealed class Example4ToDictionary
    {
        public Dictionary<string, Order> OrderItemByZipCode(IEnumerable<Order> orders)
        {
            var items = new Dictionary<string, Order>();

            foreach (var order in orders)
            {
                items.Add(order.Zip, order);
            }

            return items;
        }

        public Dictionary<string, Order> OrderItemByZipCode2(IEnumerable<Order> orders)
        {
            return orders.ToDictionary(x => x.Zip);
        }
    }
}
