using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customers
    {
        Random rnd = new Random();
        List<int> CustomersOfTheDay = new List<int>();
        List<int> payingcustomers = new List<int>();

        public List<int> PayingCustomers { get { return payingcustomers; } set { payingcustomers = value; } }


        public Customers()
        {
         
        }

        private List<int> ListOfCustomers()
        {
            int CustomerNumbers = rnd.Next(10);
            List<int> CustomerList = new List<int>();

            if (CustomerNumbers != 0){
                for (int x = 1; x <= CustomerNumbers; x++)
                {
                    CustomerList.Add(x);
                }
            }
           
            return CustomerList;
        }

        private void CheckforCustomers()
        {
            CustomersOfTheDay = ListOfCustomers();
            int NumberOfCustomers = CustomersOfTheDay.Count;
                
           if (NumberOfCustomers == 0)
            {
                Console.WriteLine("\nYou didn't have any customers today.");
            }
           else
            {
                Console.WriteLine($"\nYou have {NumberOfCustomers} potential customers today.");
                Console.ReadLine();
            }
        }

        private void ToPurchaseOrNot()
        {
            int PurchaseChoice;

            for (int x = 1; x <= CustomersOfTheDay.Count; x++)
            {
                PurchaseChoice = rnd.Next(10);
                if (PurchaseChoice % 2 == 0)
                {
                    PayingCustomers.Add(x);
                }
            }
        }
                
        public void StartCustomers()
        {
            CheckforCustomers();
            ToPurchaseOrNot();
        }
     }
}
