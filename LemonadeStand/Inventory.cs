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
        int warmdrink;
        int sourdrink;
        int cupstotal;


        List<int> imperfections = new List<int>();
        public double LemonInventory { get { return lemoninventory; } set { lemoninventory = value; } }

        public double SugarInventory { get { return sugarinventory; } set { sugarinventory = value; } }

        public double IceInventory { get { return iceinventory; } set { iceinventory = value; } }

        public double CupInventory { get { return cupinventory; } set { cupinventory = value; } }

        public int SourDrink { get { return sourdrink; } set { sourdrink = value; } }

        public int WarmDrink { get { return warmdrink; } set { warmdrink = value; } }

        public int CupsTotal { get { return cupstotal; } set { cupstotal = value; } }

        public List<int> Imperfections { get { return imperfections; } set { imperfections = value; } }

        public Inventory()
        {
            
        }

        private void CheckForLemons()
        {
            if (LemonInventory == 0)
            {
                Console.WriteLine("Sorry, you don't have any lemons to make lemonade. Game Over.");
                //go to save function
            }
        }

        private void CheckForCups()
        {
            if (CupInventory == 0)
            {
                Console.WriteLine("Sorry, you don't have any cups to serve the lemonade. Game Over.");
                //go to save function
            }
        }

        private void AmountOfLemons(int LemonsNeeded)
        {            
            Console.WriteLine("\nHow many Lemons are you going to use today?");
            int LemonsUsed = int.Parse(Console.ReadLine());
            {
                if (LemonsUsed <= LemonInventory)
                {
                    LemonInventory -= LemonsUsed;
                    Console.WriteLine($"You have {LemonInventory} units of Lemons left.");
                }
                else if (LemonsUsed > LemonInventory)
                {
                    Console.WriteLine($"You only have {LemonInventory} units of Lemons. Please try again.");
                    AmountOfLemons(LemonsNeeded);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                    AmountOfLemons(LemonsNeeded);
                }
                                                                    
            }
        }

        private void AmountOfSugar(int SugarNeeded)
        {

            Console.WriteLine("\nHow much Sugar are you going to use today?");
            int SugarUsed = int.Parse(Console.ReadLine());
            if (SugarUsed < SugarNeeded || SugarInventory < SugarNeeded)
            {
                SourDrink++;
            }

            if (SugarUsed >= SugarNeeded)
            {
                if (SugarUsed <= SugarInventory)
                {
                    SugarInventory -= SugarUsed;
                    Console.WriteLine($"You have {SugarInventory} units of Sugar left.");
                }
                else if (SugarUsed > SugarInventory)
                {
                    Console.WriteLine($"You only have {SugarInventory} units of Sugar. Please try again.");
                    AmountOfSugar(SugarNeeded);
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please try again.");
                    AmountOfSugar(SugarNeeded);
                }
            }
           
        }

        private void AmountOfIce(int IceNeeded)
        {

            Console.WriteLine("\nHow much Ice are you going to use today?");
            int IceUsed = int.Parse(Console.ReadLine());
            if (IceUsed < IceNeeded || IceInventory < IceNeeded)
            {
                WarmDrink++;
            }

            if (IceUsed <= IceInventory)
            {
                IceInventory -= IceUsed;
                Console.WriteLine($"You have {IceInventory} units of Ice left.");
            }
            else if (IceUsed > IceInventory)
            {
                Console.WriteLine($"You only have {IceInventory} units of Ice. Please try again.");
                AmountOfIce(IceNeeded);
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                AmountOfIce(IceNeeded);
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

        private void ListOfImperfections()
        {
            Imperfections.Add(SourDrink);
            Imperfections.Add(WarmDrink);
        }

        public void MakeLemonade(Player playerOne, Recipe recipe)
        {
            recipe.DisplayRecipe();
            CheckForLemons();
            CheckForLemons();
            AmountOfLemons(recipe.LemonsNeeded);
            AmountOfSugar(recipe.SugarNeeded);
            AmountOfIce(recipe.IceNeeded);
            AmountOfCups();
            CostOfLemonade(playerOne);
            ListOfImperfections();

            }
    }
}
