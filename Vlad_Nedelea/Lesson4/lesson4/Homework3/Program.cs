using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBank bank1 = new Bank();
            ArrayList array1 = new ArrayList();
            array1 = bank1.GenerateFinancialTransactions(10);
            foreach(object o in array1)
            {
                var person1 = o as FinancialTransaction;
                Console.WriteLine(person1.ToString());
            }

        }
    }
}
