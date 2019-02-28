using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class FinancialTransaction
    {
        Person PersonFrom { get; }
        Person PersonTo { get; }
        double AmountOfMoney { get; }

        public FinancialTransaction(Person personFrom, Person personTo, double amountOfMoney)
        {
            PersonFrom = personFrom;
            PersonTo = personTo;
            AmountOfMoney = amountOfMoney;
        }

        public override string ToString()
        {
            return $"From { PersonFrom.Name} to {PersonTo.Name} Amount {AmountOfMoney}";
        }
    }
}
