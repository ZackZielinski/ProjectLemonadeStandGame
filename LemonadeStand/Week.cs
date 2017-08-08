using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Week
    {
        public Week()
        {
                
        }
        public void DaysOfTheWeek() {

            int Days = 1;
            
            while (Days <= 7)
            {
                Weather newDay = new Weather();
                string WeatherPredict = newDay.ForecastWeather();
                Store Supplies = new Store();
                Supplies.Product(WeatherPredict);
            }

        }
    }
}
