using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        double lemonprice = 0.20;
        double sugarprice = 0.05;
        double iceprice = 0.10;
        double cupprice = 0.20;

        public double LemonPrice { get { return lemonprice; } set { lemonprice = value; } }

        public double SugarPrice { get { return sugarprice; } set { sugarprice = value; } }

        public double IcePrice { get { return iceprice; } set { iceprice = value; } }

        public double CupPrice { get { return cupprice; } set { cupprice = value; } }

        List<double> product;

        public List<double> Product { get { return product; } set { product = value; } }

        public Store()
        {
            Product = new List<double>() { LemonPrice, SugarPrice, IcePrice, CupPrice };

        }

        private void FindWeather(string ForecastWeather)
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
            
            private void PurchaseLemons(List<double>Product, Inventory backpack, Player player){
            
            int BuyLemons = 0;
            
            Console.WriteLine($"\nThe price of lemons are ${Product[0]} per unit. How many do you wish to purchase?");
            try { BuyLemons = int.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Error. Must enter an integer.");
                PurchaseLemons(Product, backpack, player);
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
                PurchaseLemons(Product, backpack, player);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                PurchaseLemons(Product, backpack, player);
            }
        }

        private void PurchaseSugar(List<double> Product, Inventory backpack, Player player)
        {

            int BuySugar = 0;
            
            Console.WriteLine($"\nThe price of sugar is ${Product[1]} per unit. How many do you wish to purchase?");
            try { BuySugar = int.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Error. Must enter an integer.");
                PurchaseSugar(Product, backpack, player);
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
                PurchaseSugar(Product, backpack, player);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                PurchaseSugar(Product, backpack, player);
            }
        }

        private void PurchaseIce(List<double> Product, Inventory backpack, Player player)
        {

            int BuyIce = 0;
            
            Console.WriteLine($"\nThe price of Ice are ${Product[2]} per unit. How many do you wish to purchase?");
            try { BuyIce = int.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Error. Must enter an integer.");
                PurchaseIce(Product, backpack, player);
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
                PurchaseIce(Product, backpack, player);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                PurchaseIce(Product, backpack, player);
            }
        }
        private void PurchaseCups(List<double> Product, Inventory backpack, Player player)
        {

            int BuyCups = 0;
            
            Console.WriteLine($"\nThe price of cups are ${Product[3]} per unit. How many do you wish to purchase?");
            try { BuyCups = int.Parse(Console.ReadLine()); }
            catch (FormatException)
            {
                Console.WriteLine("Error. Must enter an integer.");
                PurchaseCups(Product, backpack, player);
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
                PurchaseCups(Product, backpack, player);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                PurchaseCups(Product, backpack, player);
            }
        }

        public void StartTransactions(string WeatherPredict, Inventory backpack, Player playerOne, Recipe recipe)
        {
            FindWeather(WeatherPredict);
            if (playerOne.Money <= 0)
            {
                Console.WriteLine("Darn, you don't have any money to buy supplies");
                backpack.MakeLemonade(playerOne, recipe);
            }
            else
            {
                PurchaseLemons(Product, backpack, playerOne);
                PurchaseSugar(Product, backpack, playerOne);
                PurchaseIce(Product, backpack, playerOne);
                PurchaseCups(Product, backpack, playerOne);
            }
        }

    }
}