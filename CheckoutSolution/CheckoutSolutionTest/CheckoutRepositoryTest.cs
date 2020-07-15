using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutSolution.Models;
using System.Collections.Generic;
using CheckoutSolution.Services;
using CheckoutSolution.Repositories;

namespace CheckoutSolutionTest
{
    [TestClass]
    public class CheckoutRepositoryTest
    {
        [TestMethod]
        public void CheckCheckoutBusinessLogicWithNoPromotions()
        {
            var items = new List<SKU>() {
                new SKU() { SKUID = 1, SKUName = "A", NoOfItems = 1, UnitPrice = 10  },
                new SKU() { SKUID = 2, SKUName = "B", NoOfItems = 1, UnitPrice = 10 }
            };
            ICheckoutService checkout = new CheckoutRepository();
            Assert.AreEqual(checkout.CalculateOrderValue(items), 20);
        }
        [TestMethod]
        public void CheckCheckoutBusinessLogicWithPromotions()
        {
            var items = new List<SKU>() {
                    new SKU() { SKUID=1,SKUName="A",NoOfItems=5,UnitPrice = 50 },
                    new SKU() { SKUID=2,SKUName="B",NoOfItems=5,UnitPrice = 30 },
                    new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 }
            };
            ICheckoutService checkout = new CheckoutRepository();
            Assert.AreEqual(checkout.CalculateOrderValue(items), 370);
        }
    }
}
