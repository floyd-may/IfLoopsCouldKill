using IfLoopsCouldKill.Details;
using System.Collections.Generic;
using System.Linq;

namespace IfLoopsCouldKill
{
    public sealed class Example1Where
    {
        public void RemoveUnshippedOrders(List<Order> orders)
        {
            foreach(var order in orders)
            {
                if(order.Shipped != null)
                {
                    continue;
                }

                orders.Remove(order);
            }
        }

        public IEnumerable<Order> RemoveUnshipped(IEnumerable<Order> orders)
        {
            return orders.Where(x => x.Shipped != null);
        }
    }
}
