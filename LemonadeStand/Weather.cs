using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string WeatherCast;
        public string TrueWeather;
        Random weatherChoice = new Random();
        List<string> Forecast = new List<string>() { "Sunny", "Cloudy", "Rainy", "Partly Cloudy" };
        public Weather()
        {
                
        }

        public string ForecastWeather()
        {
            return (WeatherCast = Forecast[weatherChoice.Next(1, Forecast.Count)]);
        }
        public string ActualWeather()
        {
            return (TrueWeather = Forecast[weatherChoice.Next(1, Forecast.Count)]);
        }
    }
}