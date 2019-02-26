using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class FinancialTransaction
    {
        Person CreditedPerson { get; set; }
        Person DebitedPerson { get; set; }
        double Ammount { get; set; }

        public FinancialTransaction(Person creditedPerson, Person debitedPerson, double ammount)
        {
            CreditedPerson = creditedPerson;
            DebitedPerson = debitedPerson;
            Ammount = ammount;
        }

    }
}
