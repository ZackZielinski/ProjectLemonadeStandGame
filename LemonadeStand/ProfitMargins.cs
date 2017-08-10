using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class ProfitMargins
    {
        Random rnd = new Random();
        public ProfitMargins()
        {
                
        }

        private void Payments(Player playerOne, Customers people, string TrueWeather)
        {
            int SatisfiedNumber;
            int CustomersToday = people.PayingCustomers.Count;
            playerOne.Profit = (playerOne.LemonadePrice * CustomersToday);
            playerOne.Money += playerOne.Profit;

            Console.WriteLine($"You had {CustomersToday} customers today.");
            Console.WriteLine($"Therefore, you earned ${playerOne.Profit} and your current total is ${playerOne.Money}");

            for (int x = 1; x <= people.PayingCustomers.Count;)
            {
                SatisfiedNumber = SatisfactoryFromWeather(TrueWeather);

                Console.WriteLine($"Customer {x} rated your lemonade {SatisfiedNumber} out of 5.");

            }

        }
        private int SatisfactoryFromWeather(string TrueWeather)
        {
            int Satisfied = rnd.Next(5);
            switch (TrueWeather)
            {
                case "Sunny":
                    Satisfied++;
                    break;

                case "Cloudy":
                    Satisfied--;
                    break;

                case "Rainy":
                    Satisfied -= 2;
                    break;

                default:
                    break;
            }
            if (Satisfied > 5)
            {
                Satisfied = 5;
            }
            return Satisfied;
        }
        public void CalculateProfit(Player player, Customers people, string TrueWeather)
        {
            Payments(player, people, TrueWeather);
        }
    }
}
