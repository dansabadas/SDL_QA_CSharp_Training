using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
        public class FinancialTransaction
    {
        public Person From { get; set;}
        public Person To   { get; set; }
        double Amount      { get; }

        public override string ToString()
        {
            return $"{From.Name}, {To.Name}, {Amount}"; 
        }

     


        public FinancialTransaction (Person personFrom, Person personTo, double amount)
        {
            From = personFrom;
            To = personTo;
            Amount = amount;
        }
    }
}
