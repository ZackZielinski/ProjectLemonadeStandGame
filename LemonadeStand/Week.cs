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
        public void DaysOfTheWeek(Player playerOne) {

            int Days = 1;

           
       
            while (Days <= 7)
            {
                Console.WriteLine($"Day: {Days}, Cash: {playerOne.Money}, Lemons: {playerOne.LemonInventory}, Sugar: {playerOne.SugarInventory}, Ice: {playerOne.IceInventory}, Cups: {playerOne.CupInventory}");
                Weather newDay = new Weather();
                string WeatherPredict = newDay.ForecastWeather();
                string TrueWeather = newDay.ActualWeather();

                Store Supplies = new Store();
                Supplies.Purchase(WeatherPredict);
                Supplies.StartTransactions(playerOne);

                CustomerSatisfaction People = new CustomerSatisfaction();
                People.Satisfactory(TrueWeather, playerOne);
                
            }

        }
    }
}
