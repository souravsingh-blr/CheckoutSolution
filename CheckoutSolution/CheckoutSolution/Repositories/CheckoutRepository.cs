using CheckoutSolution.Models;
using CheckoutSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution.Repositories
{
    public class CheckoutRepository : ICheckoutService
    {
        public int CalculateOrderValue(List<SKU> items)
        {
            var cart = new Cart() { Items = items, OrderValue = 0 };
            IPromotionEngineService promotionService = new PromotionEngineRepository();
            cart.OrderValue = promotionService.OrderSumAfterPromotions(cart);
            return cart.OrderValue;
        }
    }
}
