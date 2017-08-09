using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        double money = 20.00;
        double lemoninventory = 0;
        double sugarinventory = 0;
        double iceinventory = 0;
        double cupinventory = 0;
        double lemonadeprice;
        string name;
        public double Money { get { return money; } set { money = value; } }

        public double LemonInventory { get { return lemoninventory; } set { lemoninventory = value; } }

        public double SugarInventory { get { return sugarinventory; } set { sugarinventory = value; } }

        public double IceInventory { get { return iceinventory; } set { iceinventory = value; } }

        public double CupInventory { get { return cupinventory; } set { cupinventory = value; } }

        public double LemonadePrice { get { return lemonadeprice; } set { lemonadeprice = value; } }

        public Player()
        {
            Console.WriteLine("Enter Player Name");
            name = Console.ReadLine();
        }
        public void Rules()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
            Console.WriteLine("You will have 7 days to earn as much money from selling lemonade");
            Console.WriteLine($"You will need to supply yourself, so we will start you off with ${Money}");
        }
    }
}
