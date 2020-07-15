using CheckoutSolution.Models;
using CheckoutSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution.Repositories
{
    public class Promotion1 : IPromotion
    {
        public void ApplyPromotion(Cart cart)
        {
            int sum = cart.OrderValue;
            int noOfAs=0;
            int unitPrice = 0;
            for (int i = 0; i < cart.Items.Count; i++)
            {
                if (cart.Items[i].SKUName == "A")
                {
                    noOfAs= cart.Items[i].NoOfItems;
                    unitPrice = cart.Items[i].UnitPrice;
                }
            }

            sum = (noOfAs / 3) * 130;
            sum = sum + ((noOfAs % 3) * unitPrice);
            cart.OrderValue = sum;
        }
    }
}
