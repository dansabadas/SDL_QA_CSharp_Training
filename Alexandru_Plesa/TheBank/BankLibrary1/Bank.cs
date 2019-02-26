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
            return allTransaction;
        }

        public IList<Person> GeneratePersonBalance(ArrayList tranzactions)
        {
            IList<Person> people = new List<Person>();

            foreach(FinancialTransaction financialTransaction in tranzactions)
            {
                Person personExists = people.FirstOrDefault<Person>(pers => pers.Id == financialTransaction.CreditedPerson.Id);

                if (personExists == null)
                {
                    people.Add(financialTransaction.CreditedPerson);
                }

                int giver = people.IndexOf(people.FirstOrDefault<Person>(prs => prs.Id == financialTransaction.CreditedPerson.Id));
                int receiver = people.IndexOf(people.FirstOrDefault<Person>(prs => prs.Id == financialTransaction.DebitedPerson.Id));

                people[giver].Ballance -= financialTransaction.Ammount;
                people[receiver].Ballance += financialTransaction.Ammount;
            }
            return people;
        }
    }
}
