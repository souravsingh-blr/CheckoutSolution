using CheckoutSolution.Models;
using CheckoutSolution.Repositories;
using CheckoutSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution
{
    public class CheckoutEngine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your Bill After Promotions Applied:");

            /*Test Case 1*/
            //List<SKU> items = new List<SKU>() {
            //    new SKU() { SKUID=1,SKUName="A",NoOfItems=3,UnitPrice = 50 },
            //    new SKU() { SKUID=2,SKUName="B",NoOfItems=5,UnitPrice = 30 },
            //    new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 },
            //    new SKU() { SKUID=3,SKUName="D",NoOfItems=1,UnitPrice=  15 }
            //};
            /*Test Case 2*/
            //List<SKU> items = new List<SKU>() {
            //    new SKU() { SKUID=1,SKUName="A",NoOfItems=1,UnitPrice = 50 },
            //    new SKU() { SKUID=2,SKUName="B",NoOfItems=1,UnitPrice = 30 },
            //    new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 }
            //};
            /*Test Case 3*/
            List<SKU> items = new List<SKU>() {
                new SKU() { SKUID=1,SKUName="A",NoOfItems=5,UnitPrice = 50 },
                new SKU() { SKUID=2,SKUName="B",NoOfItems=5,UnitPrice = 30 },
                new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 }
            };
            Console.WriteLine(new CheckoutEngine().CalculateOrderValue(items));
            Console.ReadKey();
        }

        public  int CalculateOrderValue(List<SKU> items)
        {
            ICheckoutService checkout = new CheckoutRepository();
            return checkout.CalculateOrderValue(items);
        }
    }
}
