using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Bank
{
    class FinancialTransaction
    {
        public FinancialTransaction(Person from, Person to, double amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }

        Person From { get; }
        Person To { get; }
        double Amount { get; }


        public override string ToString()
        {
            return $"Finanancial transaction, amount {Amount.ToString("C")}, from {From.Name} to {To.Name}";
        }
    }
}
