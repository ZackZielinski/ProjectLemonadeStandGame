using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        double lemoninventory;
        double sugarinventory;
        double iceinventory;
        double cupinventory;

        public double LemonInventory { get { return lemoninventory; } set { lemoninventory = value; } }

        public double SugarInventory { get { return sugarinventory; } set { sugarinventory = value; } }

        public double IceInventory { get { return iceinventory; } set { iceinventory = value; } }

        public double CupInventory { get { return cupinventory; } set { cupinventory = value; } }

        public Inventory()
        {
            
        }

        private void AmountOfLemons(){

            Console.WriteLine("\nHow many Lemons are you going to use today?");
            int LemonsUsed = int.Parse(Console.ReadLine());

            if (LemonsUsed <= LemonInventory)
            {
                LemonInventory -= LemonsUsed;
                Console.WriteLine($"You have {LemonInventory} units of Lemons left.");
            }
            else if (LemonsUsed > LemonInventory) {
                Console.WriteLine($"You only have {LemonInventory} units of Lemons. Please try again.");
                AmountOfLemons();
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                AmountOfLemons();
            }
        }
        private void AmountOfSugar()
        {

            Console.WriteLine("\nHow much Sugar are you going to use today?");
            int SugarUsed = int.Parse(Console.ReadLine());

            if (SugarUsed <= SugarInventory)
            {
                SugarInventory -= SugarUsed;
                Console.WriteLine($"You have {SugarInventory} units of Sugar left.");
            }
            else if (SugarUsed > SugarInventory)
            {
                Console.WriteLine($"You only have {SugarInventory} units of Sugar. Please try again.");
                AmountOfSugar();
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                AmountOfSugar();
            }
        }
        private void AmountOfIce()
        {

            Console.WriteLine("\nHow much Ice are you going to use today?");
            int IceUsed = int.Parse(Console.ReadLine());

            if (IceUsed <= IceInventory)
            {
                IceInventory -= IceUsed;
                Console.WriteLine($"You have {IceInventory} units of Ice left.");
            }
            else if (IceUsed > IceInventory)
            {
                Console.WriteLine($"You only have {IceInventory} units of Ice. Please try again.");
                AmountOfIce();
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                AmountOfIce();
            }
        }

        private void AmountOfCups()
        {
            Console.WriteLine("\nHow many Cups are you going to make today?");
            int CupsUsed = int.Parse(Console.ReadLine());

            if (CupsUsed <= CupInventory)
            {
                CupInventory -= CupsUsed;
                Console.WriteLine($"You have {CupInventory} Cups left.");
            }
            else if (CupsUsed > CupInventory)
            {
                Console.WriteLine($"You only have {CupInventory} Cups. Please try again.");
                AmountOfCups();
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                AmountOfCups();
            }
        }

        private void CostOfLemonade(Player playerOne)
        {
            Console.WriteLine("\nHow much are you selling your lemonade per cup?");
            playerOne.LemonadePrice = Math.Round(double.Parse(Console.ReadLine()),2);
            if (playerOne.LemonadePrice >= 5.01)
            {
                Console.WriteLine("I think that's too much for lemonade, try a smaller number");
                CostOfLemonade(playerOne);
            }
            else if (playerOne.LemonadePrice <= 0.10)
            {
                Console.WriteLine("You have to make some profit at least. Please try again.");
                CostOfLemonade(playerOne);
            }
            else if (playerOne.LemonadePrice <= 5 && playerOne.LemonadePrice > 0.00)
            {
                Console.WriteLine("Great. Now we just need to wait for your customers to arrive.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                CostOfLemonade(playerOne);
            }
        }

        public void MakeLemonade(Player playerOne)
        {
            Console.WriteLine("\nNow you need to make the lemonade.");
            AmountOfLemons();
            AmountOfSugar();
            AmountOfIce();
            AmountOfCups();
            CostOfLemonade(playerOne);
        }
    }
}
