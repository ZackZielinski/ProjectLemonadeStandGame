using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public Store()
        {
        
        }

        public void Product(string ForecastWeather)
        {
            string DayWeather = ForecastWeather;
            double LemonPrice = 0.20;
            double SugarPrice = 0.05;
            double IcePrice = 0.10;
            double CupPrice = 0.20;

            List<double> Product = new List<double>() { LemonPrice, SugarPrice, IcePrice, CupPrice };

            switch (DayWeather)
            {
                case "Partly Cloudy":
                    Console.WriteLine($"The forecast is {DayWeather}, so the store didn't have to change the price.");
                    break;

                case "Rainy":
                    Console.WriteLine($"The forecast is {DayWeather}, prices have been cut in half.");
                    for (int x = 0; x <= Product.Count; x++)
                    {
                        Product[x] *= .5;
                    }
                    break;

                case "Sunny":
                    Console.WriteLine($"The forecast is {DayWeather}, prices have been doubled.");
                    for (int x = 0; x <= Product.Count; x++)
                    {
                        Product[x] *= 2;
                    }
                    break;

                case "Cloudy":
                    Console.WriteLine($"The forecast is {DayWeather}, so the store has dropped 1/4 the prices.");
                    for (int x = 0; x <= Product.Count; x++)
                    {
                        Product[x] *= .25;
                    }
                    break;
            }
        }
            
            private void LemonPurchase(List<double>Product, Player player){
            
            int BuyLemons;
            
            Console.WriteLine($"The price of lemons are {Product[1]} per unit. How many do you wish to purchase?");
            BuyLemons = int.Parse(Console.ReadLine());

            if (player.Money - (Product[1] * BuyLemons) >=0)
            {
                player.LemonInventory += (player.LemonInventory + BuyLemons);
                player.Money = (player.Money - (Product[1] * BuyLemons));
            }
            else if ((player.Money - (Product[1] * BuyLemons)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please enter again.");
                LemonPurchase(Product, player);
            }
        }

        private void SugarPurchase(List<double> Product, Player player)
        {

            int BuySugar;

            Console.WriteLine($"The price of lemons are {Product[2]} per unit. How many do you wish to purchase?");
            BuySugar = int.Parse(Console.ReadLine());

            if (player.Money - (Product[2] * BuySugar) >= 0)
            {
                player.LemonInventory += (player.LemonInventory + BuySugar);
                player.Money = (player.Money - (Product[1] * BuySugar));
            }
            else if ((player.Money - (Product[2] * BuySugar)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please enter again.");
                SugarPurchase(Product, player);
            }
        }

        private void IcePurchase(List<double> Product, Player player)
        {

            int BuyIce;

            Console.WriteLine($"The price of lemons are {Product[2]} per unit. How many do you wish to purchase?");
            BuyIce = int.Parse(Console.ReadLine());

            if (player.Money - (Product[2] * BuyIce) >= 0)
            {
                player.LemonInventory += (player.LemonInventory + BuyIce);
                player.Money = (player.Money - (Product[1] * BuyIce));
            }
            else if ((player.Money - (Product[2] * BuyIce)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please enter again.");
                IcePurchase(Product, player);
            }
        }

    }
}
