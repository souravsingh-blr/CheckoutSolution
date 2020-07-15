using CheckoutSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution.Services
{
    public interface IPromotionEngineService
    {
        List<IPromotion> GetAllActivePromotions();
        int OrderSumAfterPromotions(Cart cart);
    }
}
