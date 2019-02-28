using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1  
// Then create a class Bank which implements the interface IBank, so in the method implementation you will generate some (let's say around 20) FinancialTransaction objects. 
// In the implementation let's say that at every 3 transactions the To person repeats and at every 5 transactions the From person repeats. 
// Also the amount will be some random number between 100 and 200 (so we don't waste too much money).
// 4. At the end please print at the console the transactions: the From person's name, the To Person's name and the Amount! 
{
    public class Bank 
    {
        public ArrayList GenerateFinancialTransactions(int numberOfTransactions)
        {
            ArrayList transactions = new ArrayList();
            Random rand1 = new Random();

            for (int trans = 0; trans < numberOfTransactions; trans++)
            {
                DateTime birthDate = default(DateTime);
                Person personTo = new Person((0 == trans % 3), "Person" + (0 == trans % 3), birthDate);
                Person personFrom = new Person((0 == trans * 5), "Person" + (0 == trans % 5), birthDate);
               
                FinancialTransaction financialTransaction = new FinancialTransaction(personTo, personFrom, rand1.Next(100, 200));
                transactions.Add(financialTransaction);
            }
            return transactions;
        }
    }
}
