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
            IBank bank = new Bank();
            ArrayList array = new ArrayList();
            array = bank.GenerateFinancialTransactions(10);
            foreach (object obj in array)
            {
                var person = obj as FinancialTransaction;
                Console.WriteLine(person.ToString());
            }

        }
    }
}
