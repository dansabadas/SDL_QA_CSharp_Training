using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public interface IBank
    {
        ArrayList GenerateFinancialTransactions(int numberOfTransactions);

    }

    public class Bank : IBank
    {
        public ArrayList GenerateFinancialTransactions(int numberOfTransactions)
        {
            ArrayList list = new ArrayList();

            Person person_from_def = new Person(3, "person3", new DateTime(10 / 10 / 1876));
            Person person_to_def = new Person(5, "person5", new DateTime(10 / 10 / 1678));

            Random rnd = new Random();

            for (int i = 0; i < numberOfTransactions; i++)
            {
                Person person_to = new Person(i, "person" + i, new DateTime(10 / 10 / (1980) + i));

                Person person_from = new Person(i * 3, "person" + i * 3, new DateTime(10 / 10 / (1980) + i * 3));

                var money_amount = rnd.Next(100, 200);

                if (i % 3 == 0)
                {
                    person_from = person_from_def;
                }

                if (i % 5 == 0)
                {
                    person_to = person_to_def;
                }

                FinancialTransaction transaction = new FinancialTransaction(person_from, person_to, money_amount);

                list.Add(transaction);
            }
            return list;
        }
    }
}