using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bid501Server
{
    class Product
    {
        public int bids { get; set; }
        public decimal bidPrice { get; set; }
        public string name { get; set; }

        public Product(string name)
        {
            this.name = name;
        }
    }
}
