﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CheckoutSolution.Models;
using CheckoutSolution.Services;
using CheckoutSolution.Repositories;

namespace CheckoutSolutionTest
{
    [TestClass]
    public class Promotion2Test
    {
       
        [TestMethod]
        public void TestAfterApplyingPromotion2()
        {
            var items = new List<SKU>() {
                    new SKU() { SKUID=1,SKUName="A",NoOfItems=5,UnitPrice = 50 },
                    new SKU() { SKUID=2,SKUName="B",NoOfItems=5,UnitPrice = 30 },
                    new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 }
            };
            IPromotion service = new Promotion2();
            var cart = new Cart() { Items = items, OrderValue = 0 };
            service.ApplyPromotion(cart);
            Assert.AreEqual(cart.OrderValue, 120);
        }
    }
}
