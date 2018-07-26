using IfLoopsCouldKill.Details;
using System.Collections.Generic;
using System.Linq;

namespace IfLoopsCouldKill
{
    public sealed class Example6GroupBy
    {
        public Dictionary<string, int> OrderCountByZipCodeBad(IEnumerable<Order> orders)
        {
            var dict = new Dictionary<string, int>();

            foreach (var order in orders)
            {
                dict.TryGetValue(order.Zip, out var count);

                count++;

                dict[order.Zip] = count;
            }

            return dict;
        }

        public Dictionary<string, int> OrderCountByZipCode(IEnumerable<Order> orders)
            => orders
                .GroupBy(x => x.Zip)
                .ToDictionary(x => x.Key, x => x.Count());
    }
}
