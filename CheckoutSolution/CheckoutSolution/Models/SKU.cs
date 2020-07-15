using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution.Models
{
    public class SKU
    {
        public int SKUID { get; set; }
        public string SKUName { get; set; }
        public int NoOfItems { get; set; }
        public int UnitPrice { get; set; }
    }
}
