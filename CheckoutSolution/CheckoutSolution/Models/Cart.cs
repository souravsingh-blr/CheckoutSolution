using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution.Models
{
    public class Cart
    {
        public List<SKU> Items { get; set; }
        public int OrderValue { get; set; }
    }
}
