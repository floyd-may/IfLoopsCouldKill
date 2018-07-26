using System;
using System.Collections.Generic;

namespace IfLoopsCouldKill.Details
{
    public sealed class Order
    {
        public string Name { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Shipped { get; set; }

        public string ShippingAddress { get; set; }

        public string Zip { get; set; }

        public IEnumerable<OrderItem> Items { get; set; }
    }
}
