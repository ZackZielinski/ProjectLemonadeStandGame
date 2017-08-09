using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class NumberOfCustomers
    {
        Random NumberOfCustomers = new Random();
        public NumberOfCustomers()
        {
         
        }

        private void ListOfCustomers()
        {

            NumberOfCustomers.Next(10);
            List<int> CustomerList = new List<int>();
        }
    }
}
