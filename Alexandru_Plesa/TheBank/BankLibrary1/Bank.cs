using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Bank : IBank
    {
        public ArrayList GenerateFinancialTransactions(int nrOfTransactions)
        {
            ArrayList allTransaction = new ArrayList();
            Random rnd = new Random();
            

            for (int transaction = 0; transaction < nrOfTransactions; transaction++)
            {
                Person creditedPerson = new Person(transaction % 5, "Person" + (transaction % 5));
                Person debitedPerson = new Person(transaction % 3, "Person" + (transaction % 3));

                FinancialTransaction financialTransaction = new FinancialTransaction(creditedPerson, debitedPerson, rnd.Next(100, 200));
                allTransaction.Add(financialTransaction);

            }
            throw new NotImplementedException();
        }
    }
}
