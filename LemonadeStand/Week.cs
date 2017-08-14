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
            Recipe Food = new Recipe();
            Weather newDay = new Weather();
            Store Supplies = new Store();
            Customers People = new Customers();
            ProfitMargins Transactions = new ProfitMargins();

            int Days = 1;
                                                     
            while (Days < 8)
            {
                List<string> WeatherofTheDay = newDay.WeatherChanges();

                Console.WriteLine($"Day: {Days}, Cash: ${playerOne.Money}, Lemons: {playerOne.backpack.LemonInventory}, Sugar: {playerOne.backpack.SugarInventory}, Ice: {playerOne.backpack.IceInventory}, Cups: {playerOne.backpack.CupInventory}");
                                               
                Supplies.StartTransactions(WeatherofTheDay[0], playerOne.backpack, playerOne);

                playerOne.backpack.MakeLemonade(playerOne, Food);
                
                newDay.ShowRealWeather(WeatherofTheDay[1]);

                People.StartCustomers(playerOne);
                                
                Transactions.CalculateProfit(playerOne, People, WeatherofTheDay[1]);
                Days++;
            }
            //Have a function to save player.name & player.inventory 
        }
    }
}
