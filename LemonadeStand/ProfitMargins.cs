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

        private void Payments(Player playerOne, Customers people, int Satisfied)
        {

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
            if (Satisfied < 5)
            {
                Satisfied = 5;
            }
            return Satisfied;
        }
        public void CalculateProfit(Player player, Customers people, string TrueWeather)
        {
           int SatisfyNumber = SatisfactoryFromWeather(TrueWeather);

        }
    }
}
