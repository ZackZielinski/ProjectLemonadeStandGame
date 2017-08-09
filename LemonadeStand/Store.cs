using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        double LemonPrice = 0.20;
        double SugarPrice = 0.05;
        double IcePrice = 0.10;
        double CupPrice = 0.20;

        List<double> Product;

        public Store()
        {
            Product = new List<double>() { LemonPrice, SugarPrice, IcePrice, CupPrice };

        }

        public void Purchase(string ForecastWeather)
        {
           
            string DayWeather = ForecastWeather;
           
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
                player.SugarInventory += (player.SugarInventory + BuyLemons);
                player.Money = (player.Money - (Product[1] * BuyLemons));
                Console.WriteLine($"You currently have ${player.Money}");
            }
            else if ((player.Money - (Product[1] * BuyLemons)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please try a smaller number.");
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
                player.SugarInventory += (player.SugarInventory + BuySugar);
                player.Money = (player.Money - (Product[1] * BuySugar));
                Console.WriteLine($"You currently have ${player.Money}");
            }
            else if ((player.Money - (Product[2] * BuySugar)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please try a smaller amount.");
                SugarPurchase(Product, player);
            }
        }

        private void IcePurchase(List<double> Product, Player player)
        {

            int BuyIce;

            Console.WriteLine($"The price of cups are {Product[3]} per unit. How many do you wish to purchase?");
            BuyIce = int.Parse(Console.ReadLine());

            if (player.Money - (Product[3] * BuyIce) >= 0)
            {
                player.IceInventory += (player.IceInventory + BuyIce);
                player.Money = (player.Money - (Product[3] * BuyIce));
                Console.WriteLine($"You currently have ${player.Money}");
            }
            else if ((player.Money - (Product[3] * BuyIce)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please try a smaller amount.");
                IcePurchase(Product, player);
            }
        }
        private void CupPurchase(List<double> Product, Player player)
        {

            int BuyCups;

            Console.WriteLine($"The price of cups are {Product[4]} per unit. How many do you wish to purchase?");
            BuyCups = int.Parse(Console.ReadLine());

            if (player.Money - (Product[4] * BuyCups) >= 0)
            {
                player.CupInventory += (player.CupInventory + BuyCups);
                player.Money = (player.Money - (Product[4] * BuyCups));
                Console.WriteLine($"You currently have ${player.Money}");
            }
            else if ((player.Money - (Product[4] * BuyCups)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please try a smaller amount.");
                CupPurchase(Product, player);
            }
        }

        public void StartTransactions(Player playerOne)
        {
            LemonPurchase(Product, playerOne);
            SugarPurchase(Product, playerOne);
            IcePurchase(Product, playerOne);
            CupPurchase(Product, playerOne);
        }

    }
}