using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class CustomerSatisfaction
    {
        Random SatisfactoryNumber = new Random();
        public CustomerSatisfaction()
        {
            SatisfactoryNumber.Next(5);
        }
        
        public void Satisfactory(string TrueWeather, Player player)
        {
            switch (TrueWeather)
            {
                case "Sunny":
                    //+1
                    break;

                case "Cloudy":
                    //-1
                    break;

                case "Rainy":
                    //-2
                    break;

                case "Partly Cloudy":
                    //0
                    break;
            }
        }

    }
}
