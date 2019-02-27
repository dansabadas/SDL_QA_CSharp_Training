using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FinancialTransaction
    {
        public Person From { get; }
        public Person To { get; }
        public double Amount { get; }

        public FinancialTransaction(Person from, Person to, double amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
