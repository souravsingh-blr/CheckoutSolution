using CheckoutSolution.Models;
using CheckoutSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution.Repositories
{
    public class Promotion2 :  IPromotion
    {
        public void ApplyPromotion(Cart cart)
        {
            int sum = cart.OrderValue;
            int noOfBs = 0;
            int unitPrice = 0;
            for (int i = 0; i < cart.Items.Count; i++)
            {
                if (cart.Items[i].SKUName == "B")
                {
                    noOfBs= cart.Items[i].NoOfItems;
                    unitPrice = cart.Items[i].UnitPrice;
                }
            }

            sum = (noOfBs / 2) * 45;
            sum = sum + ((noOfBs % 2) * unitPrice);
            cart.OrderValue = cart.OrderValue+sum;
        }
    }
}
