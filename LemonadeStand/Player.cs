using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public double Money = 20.00;
        public double Lemon;
        public double Sugar;
        public double Ice;
        public double CupsOfLemonade;
        public string name; 

        public Player()
        {
            Console.WriteLine("Enter Player Name");
            name = Console.ReadLine();
        }
        private void Rules()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
            Console.WriteLine("You will have 7 days to earn as much money from selling lemonade");
            Console.WriteLine($"You will need to supply yourself, so we will start you off with ${Money}");

        }
    }
}
