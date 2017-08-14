using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class ProfitMargins : DisplayProfits
    {
        Random rnd = new Random();
        public ProfitMargins()
        {
                
        }

        
        private void Payments(Player playerOne, Customers people, string TrueWeather)
        {
            int SatisfyFromWeather;
            int SatisfyFromImperfections;
            int SatisfiedNumber = 0;
            int CustomersDrink;
            List<int> CustomersPaid = new List<int>();
                        
            
            for (int y = 1; y <= people.CustomersOfTheDay.Count; y++)
            {
                SatisfyFromWeather = SatisfactoryFromWeather(TrueWeather);
                SatisfyFromImperfections = SatisfactoryFromImperfections(playerOne.backpack.Imperfections);

                SatisfiedNumber = (SatisfyFromWeather + SatisfyFromImperfections);
                if (SatisfiedNumber > 5)
                {
                    SatisfiedNumber = 5;
                }
                else if (SatisfiedNumber <= 0)
                    {
                        SatisfiedNumber = 1;
                    }
                else if (SatisfiedNumber >= 3)
                {
                    CustomersPaid.Add(y);
                }
            }

            CustomersDrink = (playerOne.backpack.CupsTotal - CustomersPaid.Count);

            while (playerOne.backpack.CupsTotal > 0)
            {
                if (playerOne.backpack.CupsTotal <= CustomersPaid.Count)
                {
                    playerOne.Profit += playerOne.LemonadePrice;
                }
                else if (playerOne.backpack.CupsTotal == 0)
                {
                    Console.WriteLine("You ran out of cups to disperse.");
                    break;
                }
                playerOne.backpack.CupsTotal--;
            }

            for (int x = 1; x <= CustomersDrink; x++)
            {
                Console.WriteLine($"\nCustomer {x} rated your lemonade {SatisfiedNumber} out of 5.");
                
            }

            playerOne.Money += playerOne.Profit;

            Console.WriteLine($"\nYou had {CustomersDrink} customers today.");
            DisplayProfit(playerOne);
        }
        private int SatisfactoryFromWeather(string TrueWeather)
        {
            int Satisfied = rnd.Next(1,5);
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
            
            return Satisfied;
        }

        private int SatisfactoryFromImperfections(List<int> imperfections)
        {
            int Satisfied = 0;

            if (imperfections[0] > 0)
            {
                Satisfied -= 2;
            }
            else
            {
                Satisfied++;
            }

            if (imperfections[1] > 0)
            {
                Satisfied--;
            }
            else
            {
                Satisfied++;
            }

            return Satisfied;
        }
        
        public void CalculateProfit(Player player, Customers people, string TrueWeather)
        {
            Payments(player, people, TrueWeather);
        }
    }
}