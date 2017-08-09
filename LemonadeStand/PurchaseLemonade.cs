using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class PurchaseLemonade
    {
        Random rnd = new Random();
        public PurchaseLemonade()
        {
                
        }

        private void ToPurchaseOrNot(List<int> CustomersOfTheDay)
        {
            int PurchaseChoice;

            for (int x = 1; x <= CustomersOfTheDay.Count; x++)
            {
                PurchaseChoice = rnd.Next();
                if (PurchaseChoice % 2 != 0)
                {
                    CustomersOfTheDay.Remove(x);
                }
                else
                {
                }
            }
        }

    }
}
