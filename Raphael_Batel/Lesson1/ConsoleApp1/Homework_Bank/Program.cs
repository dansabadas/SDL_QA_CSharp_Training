using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            ArrayList financialTransactions = bank.GenerateFinancialTransactions();
            foreach(FinancialTransaction ft in financialTransactions)
            {
                Console.WriteLine(ft);
            }
        }
    }
}
