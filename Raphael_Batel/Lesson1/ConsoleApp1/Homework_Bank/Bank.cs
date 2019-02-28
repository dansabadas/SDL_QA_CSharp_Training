using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Bank
{
    interface IBank
    {
        ArrayList GenerateFinancialTransactions();
    }

    class Bank : IBank
    {
        private const int customersToCreate = 5;
        private const int financialTransactionsToCreate = 20;
        private const int toPeriod = 3;
        private const int fromPeriod = 5;

        private readonly Random rand = new Random();

        readonly List<Person> Customers = new List<Person>();


        public Bank()
        {
            for(int i = 1; i <= customersToCreate; i++)
            {
                Customers.Add(new Person(i, $"Anonymous Customer {i}", new DateTime(1960 + i, i, i)));
            }
        }

        public ArrayList GenerateFinancialTransactions()
        {
            ArrayList financialTransactions = new ArrayList();

            for (int i = 0; i < financialTransactionsToCreate; i++)
            {
                Person from = (Person)Customers[i % fromPeriod];
                Person to = (Person) Customers[i % toPeriod];
                double amount = 100 + 100 * rand.NextDouble();
                FinancialTransaction ft = new FinancialTransaction(from, to, amount);
                financialTransactions.Add(ft);
            }

            return financialTransactions;
        }
    }
}
