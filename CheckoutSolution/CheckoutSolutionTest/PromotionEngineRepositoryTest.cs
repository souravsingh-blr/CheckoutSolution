using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutSolution.Models;
using System.Collections.Generic;
using CheckoutSolution.Services;
using CheckoutSolution.Repositories;

namespace CheckoutSolutionTest
{
    [TestClass]
    public class PromotionEngineRepositoryTest
    {
        [TestMethod]
        public void CheckPromotionsBusinessLogicWithNoPromotions()
        {
            var items = new List<SKU>() {
                new SKU() { SKUID = 1, SKUName = "A", NoOfItems = 1, UnitPrice = 10  },
                new SKU() { SKUID = 2, SKUName = "B", NoOfItems = 1, UnitPrice = 10 }
            };
            IPromotionEngineService service = new PromotionEngineRepository();
            Assert.AreEqual(service.OrderSumAfterPromotions(new Cart() { Items=items,OrderValue=0 }), 20);
        }
        [TestMethod]
        public void CheckPromotionsBusinessLogicWithComplexPromotions()
        {
            var items = new List<SKU>() {
                    new SKU() { SKUID=1,SKUName="A",NoOfItems=5,UnitPrice = 50 },
                    new SKU() { SKUID=2,SKUName="B",NoOfItems=5,UnitPrice = 30 },
                    new SKU() { SKUID=3,SKUName="C",NoOfItems=1,UnitPrice=  20 }
            };
            IPromotionEngineService service = new PromotionEngineRepository();
            Assert.AreEqual(service.OrderSumAfterPromotions(new Cart() { Items = items, OrderValue = 0 }), 370);
        }
        [TestMethod]
        public void CheckAllActivePromotions()
        {
            IPromotionEngineService service = new PromotionEngineRepository();
            Assert.AreEqual(service.GetAllActivePromotions().Count, 3);
        }
    }
}
