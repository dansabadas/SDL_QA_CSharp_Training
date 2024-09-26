using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public interface IBank
    {
        ArrayList GenerateFinancialTransactions(int nrOfTransactions);
        IList<Person> GeneratePersonBalance(ArrayList tranzactions);
    }
}
