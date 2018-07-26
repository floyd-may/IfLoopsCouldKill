using IfLoopsCouldKill.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfLoopsCouldKill
{
    public sealed class Example5ToLookup
    {
        public void Playground(IEnumerable<Order> orders)
        {
            var lookup = OrderItemsByZipCode(orders);

            Console.WriteLine(lookup["asdf"]); // probably empty

            Console.WriteLine(lookup["74103"]); // maybe legit
        }

        public ILookup<string, Order> OrderItemsByZipCode(IEnumerable<Order> orders)
        {
            return orders.ToLookup(x => x.Zip);
        }
    }
}
