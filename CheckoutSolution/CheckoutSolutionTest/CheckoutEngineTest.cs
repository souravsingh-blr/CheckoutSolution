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
        public void CheckOrderValueWithoutPromotions()
        {
            var items = new List<SKU>() {
                new SKU() { SKUID = 1, SKUName = "A", NoOfItems = 1, UnitPrice = 10  },
                new SKU() { SKUID = 2, SKUName = "B", NoOfItems = 1, UnitPrice = 10 }
            };
            var orderValue = new CheckoutEngine().CalculateOrderValue(items);
            Assert.AreEqual(orderValue,20);
        }
        [TestMethod]
        public void CheckOrderValueWithPromotions_SingleABC()
        {
            var items = new List<SKU>() {
                    new SKU() { SKUID=1,SKUName="A",NoOfItems=1,UnitPrice = 50 },
                    new SKU() { SKUID=2,SKUName="B",NoOfItems=1,UnitPrice = 30 },
                    new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 }
            };
            var orderValue = new CheckoutEngine().CalculateOrderValue(items);
            Assert.AreEqual(orderValue, 100);
        }
        [TestMethod]
        public void CheckOrderValueWithPromotions_MultipleAandBandSingleC()
        {
            var items = new List<SKU>() {
                    new SKU() { SKUID=1,SKUName="A",NoOfItems=5,UnitPrice = 50 },
                    new SKU() { SKUID=2,SKUName="B",NoOfItems=5,UnitPrice = 30 },
                    new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 }
            };
            var orderValue = new CheckoutEngine().CalculateOrderValue(items);
            Assert.AreEqual(orderValue, 370);
        }
        [TestMethod]
        public void CheckOrderValueWithPromotions_MultipleAandB()
        {
            var items = new List<SKU>() {
                    new SKU() { SKUID=1,SKUName="A",NoOfItems=3,UnitPrice = 50 },
                    new SKU() { SKUID=2,SKUName="B",NoOfItems=5,UnitPrice = 30 },
                    new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 },
                    new SKU() { SKUID=3,SKUName="D",NoOfItems=1,UnitPrice=  15 }
            };
            var orderValue = new CheckoutEngine().CalculateOrderValue(items);
            Assert.AreEqual(orderValue, 280);
        }
    }
}
