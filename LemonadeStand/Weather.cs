using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string DayWeather;
        public Weather()
        {
                
        }
        private void CurrentWeather()
        {
            List<string> Forecast = new List<string>() { "Sunny" , "Cloudy" , "Rainy" , "Partly Cloudy"};

            Random weatherChoice =  new Random();

            DayWeather = Forecast[weatherChoice.Next(1,Forecast.Count)];
        }

    }
}