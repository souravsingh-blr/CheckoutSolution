using CheckoutSolution.Models;
using CheckoutSolution.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutSolution.Repositories
{
    public class Promotion3 : IPromotion
    {
        public void ApplyPromotion(Cart cart)
        {
            int sum = cart.OrderValue;
            int noOfCs = 0;
            int noOfDs = 0;
            int unitPriceOfC = 0;
            int unitPriceOfD = 0;
            for (int i = 0; i < cart.Items.Count; i++)
            {
                if (cart.Items[i].SKUName == "C")
                {
                    noOfCs= cart.Items[i].NoOfItems;
                    unitPriceOfC = cart.Items[i].UnitPrice;
                }
                if (cart.Items[i].SKUName == "D")
                {
                    noOfDs= cart.Items[i].NoOfItems;
                    unitPriceOfD = cart.Items[i].UnitPrice;
                }
            }

            if (noOfCs >= 1 && noOfDs >= 1)
            {
                while (noOfCs !=0 || noOfDs!=0)
                {
                    sum = sum + 30;
                    noOfCs--;
                    noOfDs--;
                }
            }

            sum = sum + (noOfCs * unitPriceOfC );
            sum = sum + (noOfDs * unitPriceOfD);
            cart.OrderValue = sum;
        }
    }
}