using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customers : DisplayProfits
    {
        Random rnd = new Random();
        int customernumbers;

        public int CustomerNumbers { get { return customernumbers; } set { customernumbers = value; } }

        List<int> customersoftheday = new List<int>();
        
        public List<int> CustomersOfTheDay { get { return customersoftheday; } set { customersoftheday = value; } }

        public Customers()
        {
         
        }

        private List<int> ListOfCustomers()
        {
            CustomerNumbers = rnd.Next(10);
            List<int> CustomerList = new List<int>();

            if (CustomerNumbers != 0){
                for (int x = 1; x <= CustomerNumbers; x++)
                {
                    CustomerList.Add(x);
                }
            }
           
            return CustomerList;
        }

        private void CheckforCustomers(Player playerOne)
        {
            CustomersOfTheDay = ListOfCustomers();
            int NumberOfCustomers = CustomersOfTheDay.Count;
                
           if (NumberOfCustomers == 0)
            {
                Console.WriteLine("\nYou didn't have any customers today.");
                DisplayProfit(playerOne);
            }
           else
            {
                Console.WriteLine($"\nYou have {NumberOfCustomers} potential customers today.");
                Console.ReadLine();
            }
        }
                
        public void StartCustomers(Player playerOne)
        {
            CheckforCustomers(playerOne);
        }
     }
}
