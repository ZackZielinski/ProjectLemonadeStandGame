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
        public void DaysOfTheWeek(Player playerOne)
        {
            Weather newDay = new Weather();
            Store Supplies = new Store();
            Customers People = new Customers();
            ProfitMargins Transactions = new ProfitMargins();
            int Days = 1;

                                         
            while (Days < 8)
            {
                Console.WriteLine($"Day: {Days}, Cash: ${playerOne.Money}, Lemons: {playerOne.backpack.LemonInventory}, Sugar: {playerOne.backpack.SugarInventory}, Ice: {playerOne.backpack.IceInventory}, Cups: {playerOne.backpack.CupInventory}");

                
                string WeatherPredict = newDay.WeatherChange();
                string TrueWeather = newDay.WeatherChange();

                
                Supplies.StartTransactions(WeatherPredict, playerOne.backpack, playerOne);

                playerOne.backpack.MakeLemonade(playerOne);

                People.StartCustomers();
                                
                Transactions.CalculateProfit(playerOne, People, TrueWeather);
            }

        }
    }
}
