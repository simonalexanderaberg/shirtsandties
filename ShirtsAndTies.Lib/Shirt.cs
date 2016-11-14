using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtsAndTies.Lib
{
    public class Shirt
    {
        public string Size { get; set; }
        public decimal UnitPrice { get; set; }
        public string Color { get; set; }
        public IList<Vendor> Vendors { get; set; }
    }
}
