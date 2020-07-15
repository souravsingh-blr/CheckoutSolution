using CheckoutSolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution.Services
{
    public interface IPromotion
    {
        void ApplyPromotion(Cart cart);
    }
}
