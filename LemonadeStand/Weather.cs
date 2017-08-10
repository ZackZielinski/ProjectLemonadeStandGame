using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        string weathercast;
        string trueweather;
        public string WeatherCast { get { return weathercast; } set { weathercast = value; } }
        public string TrueWeather { get { return trueweather; } set { trueweather = value; } }

        Random weatherChoice = new Random();
        List<string> Forecast = new List<string>() { "Sunny", "Cloudy", "Rainy", "Partly Cloudy" };
        public Weather()
        {
                
        }

        public string WeatherChange()
        {
            return (WeatherCast = Forecast[weatherChoice.Next(1, Forecast.Count)]);
        }
    }
}