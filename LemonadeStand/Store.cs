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

        private void Purchase(string ForecastWeather)
        {
            Console.WriteLine("You will need to go to the store to supply yourself for lemonade.");
            Console.ReadKey();

            Console.WriteLine($"\nThe prices are: \nLemons: ${LemonPrice} \nSugar: ${SugarPrice} \nIce: ${IcePrice} \nCups: ${CupPrice}");
            Console.ReadKey();

            string DayWeather = ForecastWeather;
           
            switch (DayWeather)
            {
                
                case "Rainy":
                    Console.WriteLine($"\nThe Forecast is {DayWeather}, prices have been cut in half.");
                    for (int x = 0; x < Product.Count; x++)
                    {
                        Product[x] = Math.Round(Product[x] * 0.5 , 2);
                    }
                    break;

                case "Sunny":
                    Console.WriteLine($"\nThe Forecast is {DayWeather}, prices have been doubled.");
                    for (int x = 0; x < Product.Count; x++)
                    {
                        Product[x] = Math.Round(Product[x] * 2, 2);
                    }
                    break;

                case "Cloudy":
                    Console.WriteLine($"\nThe Forecast is {DayWeather}, so the store has dropped 1/4 the prices.");
                    for (int x = 0; x < Product.Count; x++)
                    {
                        Product[x] = Math.Round(Product[x] *0.25, 2);
                    }
                    break;
                default:
                    Console.WriteLine($"\nThe Forecast is {DayWeather}, so the store didn't have to change the price.");
                    break;
            }
            Console.ReadKey();
        }
            
            private void LemonPurchase(List<double>Product, Inventory backpack, Player player){
            
            int BuyLemons = 0;
            
            Console.WriteLine($"\nThe price of lemons are ${Product[0]} per unit. How many do you wish to purchase?");
            try { BuyLemons = int.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Error. Must enter an integer.");
                LemonPurchase(Product, backpack, player);
            }

            if (player.Money - (Product[0] * BuyLemons) >=0)
            {
                backpack.LemonInventory += (backpack.LemonInventory + BuyLemons);
                player.Money = Math.Round((player.Money - (Product[0] * BuyLemons)), 2);
                Console.WriteLine($"You currently have ${player.Money}");
            }
            else if ((player.Money - (Product[0] * BuyLemons)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please try a smaller number.");
                LemonPurchase(Product, backpack, player);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                LemonPurchase(Product, backpack, player);
            }
        }

        private void SugarPurchase(List<double> Product, Inventory backpack, Player player)
        {

            int BuySugar = 0;

            Console.WriteLine($"\nThe price of sugar is ${Product[1]} per unit. How many do you wish to purchase?");
            try { BuySugar = int.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Error. Must enter an integer.");
                SugarPurchase(Product, backpack, player);
            }


            if (player.Money - (Product[1] * BuySugar) >= 0)
            {
                backpack.SugarInventory += (backpack.SugarInventory + BuySugar);
                player.Money = Math.Round((player.Money - (Product[1] * BuySugar)), 2);
                Console.WriteLine($"You currently have ${player.Money}");
            }
            else if ((player.Money - (Product[1] * BuySugar)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please try a smaller amount.");
                SugarPurchase(Product, backpack, player);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                SugarPurchase(Product, backpack, player);
            }
        }

        private void IcePurchase(List<double> Product, Inventory backpack, Player player)
        {

            int BuyIce = 0;

            Console.WriteLine($"\nThe price of Ice are ${Product[2]} per unit. How many do you wish to purchase?");
            try { BuyIce = int.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Error. Must enter an integer.");
                IcePurchase(Product, backpack, player);
            }

            if (player.Money - (Product[2] * BuyIce) >= 0)
            {
                backpack.IceInventory += (backpack.IceInventory + BuyIce);
                player.Money = Math.Round((player.Money - (Product[2] * BuyIce)),2);
                Console.WriteLine($"You currently have ${player.Money}");
            }
            else if ((player.Money - (Product[2] * BuyIce)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please try a smaller amount.");
                IcePurchase(Product, backpack, player);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                IcePurchase(Product, backpack, player);
            }
        }
        private void CupPurchase(List<double> Product, Inventory backpack, Player player)
        {

            int BuyCups = 0;

            Console.WriteLine($"\nThe price of cups are ${Product[3]} per unit. How many do you wish to purchase?");
            try { BuyCups = int.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Error. Must enter an integer.");
                CupPurchase(Product, backpack, player);
            }

            if (player.Money - (Product[3] * BuyCups) >= 0)
            {
                backpack.CupInventory += (backpack.CupInventory + BuyCups);
                player.Money = Math.Round((player.Money - (Product[3] * BuyCups)),2);
                Console.WriteLine($"You currently have ${player.Money}");
            }
            else if ((player.Money - (Product[3] * BuyCups)) <= 0)
            {
                Console.WriteLine("Not enough Cash. Please try a smaller amount.");
                CupPurchase(Product, backpack, player);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                CupPurchase(Product, backpack, player);
            }
        }

        public void StartTransactions(string WeatherPredict, Inventory backpack, Player playerOne)
        {
            Purchase(WeatherPredict);
            LemonPurchase(Product, backpack, playerOne);
            SugarPurchase(Product, backpack, playerOne);
            IcePurchase(Product, backpack, playerOne);
            CupPurchase(Product, backpack, playerOne);
        }

    }
}