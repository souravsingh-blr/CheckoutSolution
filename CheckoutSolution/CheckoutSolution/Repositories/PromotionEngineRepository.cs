using CheckoutSolution.Models;
using CheckoutSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution.Repositories
{
    public class PromotionEngineRepository : IPromotionEngineService
    {
        public List<IPromotion> GetAllActivePromotions()
        {
            return new List<IPromotion>() { new Promotion1(),new Promotion2(),new Promotion3() };
        }
        public int OrderSumAfterPromotions(Cart cart)
        {
            foreach (IPromotion promotion in GetAllActivePromotions())
            {
                promotion.ApplyPromotion(cart);
            }
            return cart.OrderValue;
        }
    }
}
