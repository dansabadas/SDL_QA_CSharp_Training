using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
// 2. create a class FinancialTransaction with 3 getter only properties: Person From, Person To and double Amount so this class represents 
// a financial transaction where the From person sends the Amount of money to the To person
{
    class FinancialTransaction
    {
        private Person personTo;
        private Person personFrom;
        private int v;

        public string PersonFrom { get; }
        public string PersonTo { get; }
        public double Amount { get; }

        public FinancialTransaction(string personFrom, string personTo, double amount)
        {
            PersonFrom = personFrom;
            PersonTo = personTo;
            Amount = amount;
        }

        public FinancialTransaction(Person personTo, Person personFrom, int v)
        {
            this.personTo = personTo;
            this.personFrom = personFrom;
            this.v = v;
        }
    }
}
