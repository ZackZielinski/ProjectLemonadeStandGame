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
        List<string> Forecast;
        public Weather()
        {
            Forecast = new List<string>() { "Sunny", "Cloudy", "Rainy", "Partly Cloudy" };
        }

        private string CurrentWeather()
        {
            return (WeatherCast = Forecast[weatherChoice.Next(1, Forecast.Count)]);
        }

        public void ShowRealWeather(string CurrentWeather)
        {
            Console.WriteLine($"\nThe actual weather today is {CurrentWeather}.");
            Console.ReadKey();
        }
        public List<string> WeatherChanges()
        {
            List<string> WeatherOfTheDay = new List<string>();
            string WeatherPredict = CurrentWeather();
            string TrueWeather = CurrentWeather();

            WeatherOfTheDay.Add(WeatherPredict);
            WeatherOfTheDay.Add(TrueWeather);

            return WeatherOfTheDay;
        }
    }
}