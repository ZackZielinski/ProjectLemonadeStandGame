using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class DisplayProfits
    {
        public DisplayProfits()
        {

        }

        public void DisplayProfit(Player playerOne)
        {
            Console.WriteLine($"Therefore, you earned ${playerOne.Profit} and your current total is ${playerOne.Money}");
            Console.ReadLine();
        }
    }
}
