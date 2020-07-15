using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CheckoutSolution.Models;
using CheckoutSolution;

namespace CheckoutSolutionTest
{
    [TestClass]
    public class CheckoutEngineTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var items = new List<SKU>() {
                new SKU() { SKUID = 1, SKUName = "A", NoOfItems = 1, UnitPrice = 10  },
                new SKU() { SKUID = 2, SKUName = "B", NoOfItems = 1, UnitPrice = 10 }
            };
            var orderValue = new CheckoutEngine().CalculateOrderValue(items);
            Assert.AreEqual(orderValue,20);
        }
    }
}
