using IfLoopsCouldKill.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfLoopsCouldKill
{
    public sealed class Example3SelectMany
    {
        public IEnumerable<OrderItem> GetOrderItems(IEnumerable<Order> orders)
        {
            var items = new List<OrderItem>();

            foreach (var order in orders)
            {
                foreach(var item in order.Items)
                {
                    items.Add(item);
                }
            }

            return items;
        }

        public IEnumerable<OrderItem> GetOrderItems2(IEnumerable<Order> orders)
        {
            return orders.SelectMany(x => x.Items);
        }
    }
}
