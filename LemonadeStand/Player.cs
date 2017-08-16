using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Inventory backpack = new Inventory();
        double money = 20.00;
        double lemonadeprice;
        double profit;
        string name;
        public double Money { get { return money; } set { money = value; } }

        public double LemonadePrice { get { return lemonadeprice; } set { lemonadeprice = value; } }

        public double Profit { get { return profit; } set { profit = value; } }

        public string Name { get { return name; } set { name = value; } }

        public Player()
        {
        }
        private void GetPlayerName()
        {
            Console.WriteLine("Enter Player Name");
            Name = Console.ReadLine();
            if (Name == "")
            {
                Console.WriteLine("Sorry, you need to enter in a name to continue.");
                GetPlayerName();
            }
        }
        private void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
            Console.WriteLine("You will have 7 days to earn as much money from selling lemonade");
            Console.WriteLine($"You will need to supply yourself, so we will start you off with ${Money}");
        }

        public void StartingNewGame()
        {
            DisplayRules();
            GetPlayerName();
        }

    }
}
