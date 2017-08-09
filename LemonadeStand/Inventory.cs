using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory : Player
    {
        public Inventory()
        {
            Console.WriteLine("Now you need to make the lemonade.");
        }

        private void AmountOfLemons(){

            Console.WriteLine("How many Lemons are you going to use today?");
            int LemonsUsed = int.Parse(Console.ReadLine());

            if (LemonsUsed <= SugarInventory)
            {
                LemonInventory -= LemonsUsed;
                Console.WriteLine($"You have {LemonInventory} units of Lemons left.");
            }
            else if (LemonsUsed > LemonInventory) {
                Console.WriteLine($"You only have {LemonInventory} units of Lemons. Please try again.");
                AmountOfLemons();
            }

            }
        private void AmountOfSugar()
        {

            Console.WriteLine("How many Lemons are you going to use today?");
            int SugarUsed = int.Parse(Console.ReadLine());

            if (SugarUsed <= SugarInventory)
            {
                SugarInventory -= SugarUsed;
                Console.WriteLine($"You have {SugarInventory} units of Lemons left.");
            }
            else if (SugarUsed > SugarInventory)
            {
                Console.WriteLine($"You only have {SugarInventory} units of Lemons. Please try again.");
                AmountOfSugar();
            }
        }
        private void AmountOfIce()
        {

            Console.WriteLine("How many Lemons are you going to use today?");
            int IceUsed = int.Parse(Console.ReadLine());

            if (IceUsed <= SugarInventory)
            {
                IceInventory -= IceUsed;
                Console.WriteLine($"You have {IceInventory} units of Lemons left.");
            }
            else if (IceUsed > IceInventory)
            {
                Console.WriteLine($"You only have {IceInventory} units of Lemons. Please try again.");
                AmountOfIce();
            }
        }
        public void MakeLemonade()
        {
            AmountOfLemons();
            AmountOfSugar();
            AmountOfIce();
        }
    }
}
