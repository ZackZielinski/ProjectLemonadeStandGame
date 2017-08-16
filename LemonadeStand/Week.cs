using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Week
    {
        int days = 1;

        public int Days { get { return days; } set { days = value; } }

        public Week()
        {
        }
        public void GetDaysOfTheWeek(Player playerOne)
        {
            Recipe Food = new Recipe();
            Weather newDay = new Weather();
            Store Supplies = new Store();
            Customers People = new Customers();
            ProfitMargins Transactions = new ProfitMargins();

                                                                
            while (Days < 8)
            {
                List<string> WeatherofTheDay = newDay.WeatherChanges();

                Console.WriteLine($"Day: {Days}, Cash: ${playerOne.Money}, Lemons: {playerOne.backpack.LemonInventory}, Sugar: {playerOne.backpack.SugarInventory}, Ice: {playerOne.backpack.IceInventory}, Cups: {playerOne.backpack.CupInventory}");
                                               
                Supplies.StartTransactions(WeatherofTheDay[0], playerOne.backpack, playerOne, Food);

                playerOne.backpack.MakeLemonade(playerOne, Food);
                if (playerOne.backpack.IsGameOver[0] == true || playerOne.backpack.IsGameOver[1] == true)
                {
                    break;
                }
                else
                {
                    newDay.ShowRealWeather(WeatherofTheDay[1]);

                    People.StartCustomers(playerOne);

                    Transactions.CalculateProfit(playerOne, People, WeatherofTheDay[1]);

                    Days++;
                }
            }
            DatabaseSave saveGameComplete = new DatabaseSave();
            saveGameComplete.Save(playerOne.Name, Days, Convert.ToInt32(playerOne.backpack.LemonInventory), Convert.ToInt32(playerOne.backpack.SugarInventory), Convert.ToInt32(playerOne.backpack.IceInventory), Convert.ToInt32(playerOne.backpack.CupInventory));
            DatabaseLoad loadGame = new DatabaseLoad();
            loadGame.LoadGame();
        }
    }
}
