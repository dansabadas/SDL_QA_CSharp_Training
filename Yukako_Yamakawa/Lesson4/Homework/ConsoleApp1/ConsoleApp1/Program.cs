using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
// 3. Create a interface IBank with one method: ArrayList GenerateFinancialTransactions(). Then create a class Bank which implements the interface IBank, so in the method implementation 
// you will generate some (let's say around 20) FinancialTransaction objects. 
// In the implementation let's say that at every 3 transactions the To person repeats and at every 5 transactions the From person repeats. 
// Also the amount will be some random number between 100 and 200 (so we don't waste too much money).
// 4. At the end please print at the console the transactions: the From person's name, the To Person's name and the Amount! 
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBank myBank = new Bank();
            ArrayList transactions = new ArrayList();
            transactions = myBank.GenerateFinancialTransactions();
            foreach (FinancialTransaction transact in transactions)
            {
                Console.WriteLine($"({transact.PersonFrom} {transact.PersonTo} {transact.Amount})");
            }
        }
    }
}
