using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class FinancialTransaction
    {
        public string PersonFrom;
        public string PersonTo;
        double Amount;

        public FinancialTransaction (string personFrom, string personTo, double amount)
        {
            PersonFrom = personFrom;
            PersonTo = personTo;
            Amount = amount;
        }
    }
}
