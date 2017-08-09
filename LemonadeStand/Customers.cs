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

        private void ToPurchaseOrNot(List<int> CustomersOfTheDay)
        {
            int PurchaseChoice;

            for (int x = 1; x <= CustomersOfTheDay.Count; x++)
            {
                PurchaseChoice = rnd.Next();
                if (PurchaseChoice % 2 != 0)
                {
                    CustomersOfTheDay.Remove(x);
                }
                else
                {
                    //go to satisfed
                }
            }
        }
        private int SatisfactoryFromWeather(string TrueWeather)
        {
            int Satisfied = rnd.Next(5);
            switch (TrueWeather)
            {
                case "Sunny":
                    Satisfied++;
                    break;

                case "Cloudy":
                    Satisfied--;
                    break;

                case "Rainy":
                    Satisfied -= 2;
                    break;

                default:
                    break;
            }
            if (Satisfied < 5)
            {
                Satisfied = 5;
            }
            return Satisfied;
        }

        private void CustomersBuying()
        {
            
        }

        private void CheckforCustomers()
        {
            CustomersOfTheDay = ListOfCustomers();
            int NumberOfCustomer = CustomersOfTheDay.Count;
                
           if (NumberOfCustomer == 0)
            {
                Console.WriteLine("You didn't have any customers today.");
            }
           else
            {
                ToPurchaseOrNot(CustomersOfTheDay);
            }
        }

        public void StartCustomers(string TrueWeather)
        {

        }
     }
}
