using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store : Weather
    {
        public Store()
        {
        
        }

        private void Product()
        {
            double LemonPrice = 0.20;
            double SugarPrice = 0.05;
            double IcePrice = 0.10;
            double CupPrice = 0.20;

            List<double> Product = new List<double>() {LemonPrice, SugarPrice, IcePrice, CupPrice};

            switch (DayWeather)
            {
                case "Partly Cloudy":
                    Console.WriteLine($"The weather is {DayWeather}, so the store didn't have to change the price.");
                    break;
                case "Rainy":
                    Console.WriteLine($"The weather is {DayWeather}, prices have been cut in half.");
                    for(int x = 0; x <=Product.Count; x++)
                    {
                        Product[x] *=.5; 
                    }
                    Console.WriteLine(Product);
                    break;
                case "Sunny":
                    Console.WriteLine($"The weather is {DayWeather}, prices have been doubled.");
                    for (int x = 0; x <= Product.Count; x++)
                    {
                        Product[x] *= 2;
                    }
                    Console.WriteLine(Product);
                    break;
                case "Cloudy":
                    Console.WriteLine($"The weather is {DayWeather}, so the store has dropped 1/4 the prices.");
                    for (int x = 0; x <= Product.Count; x++)
                    {
                        Product[x] *= .25;
                    }
                    Console.WriteLine(Product);
                    break;
            }
        }
    }
}
