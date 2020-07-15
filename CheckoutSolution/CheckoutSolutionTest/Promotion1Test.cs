using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutSolution.Services;
using CheckoutSolution.Repositories;
using CheckoutSolution.Models;
using System.Collections.Generic;

namespace CheckoutSolutionTest
{
    [TestClass]
    public class Promotion1Test
    {
        [TestMethod]
        public void TestAfterApplyingPromotion1()
        {
            var items = new List<SKU>() {
                    new SKU() { SKUID=1,SKUName="A",NoOfItems=5,UnitPrice = 50 },
                    new SKU() { SKUID=2,SKUName="B",NoOfItems=5,UnitPrice = 30 },
                    new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 }
            };
            IPromotion service = new Promotion1();
            var cart = new Cart() { Items = items, OrderValue = 0 };
            service.ApplyPromotion(cart);
            Assert.AreEqual(cart.OrderValue, 230);
        }
    }
}
