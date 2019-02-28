using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
// 3. Create a interface IBank with one method: ArrayList GenerateFinancialTransactions().
{
    public interface IBank
    {
        ArrayList GenerateFinancialTransactions(int transactionsMade);
        ArrayList GenerateFinancialTransactions();
    }
}
