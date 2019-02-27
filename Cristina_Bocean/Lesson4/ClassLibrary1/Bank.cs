using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IBank
    {
        ArrayList GenerateFinancialTransactions();
    }

    public class Bank : IBank
    {
        public ArrayList GenerateFinancialTransactions()
        {
            ArrayList transactions = new ArrayList();
            Random r = new Random();     

            const string repeatFrom = "Rick";
            const string repeatTo = "Morty";

            string[] FromList = new string[] { "Jane", "Emma", "Steve", "Sally", "Jack", "Penny", "Leonard", "Peter", "Sam", "Paul", "Frank", "Lilly", "Kate", "Coleen", "Anna", "Tiffany", "Kate", "Eileen", "Sarah", "Diana", "Pamela" };
            string[] ToList = new string[] { "Vivian", "Claire", "Britney", "Noah", "Sean", "Aiden", "Mason", "Jacob", "Lucas", "Elijah", "Logan", "Ethan", "James", "Liam", "Teddy", "Marcus", "Alex", "Dan", "Janie", "Zack", "Cleo" };
            for (int i = 1; i <= 20; i++)
            {
                double amount = r.NextDouble() * 100 + 100;
                if (i % 5 == 0 && i % 3 != 0)
                {
                    Person f1 = new Person(i, repeatFrom, DateTime.Today.AddYears(-i));
                    Person t1 = new Person(i, ToList[i], DateTime.Today.AddYears(-i));
                    FinancialTransaction tr1 = new FinancialTransaction(f1, t1, amount);
                    transactions.Add(tr1);
                }
                else if (i % 5 != 0 && i % 3 == 0)
                {
                    Person f2 = new Person(i, FromList[i], DateTime.Today.AddYears(-i));
                    Person t2 = new Person(i, repeatTo, DateTime.Today.AddYears(-i));
                    FinancialTransaction tr2 = new FinancialTransaction(f2, t2, amount);
                    transactions.Add(tr2);
                }
                else if (i % 15 == 0)
                {
                    Person f3 = new Person(i, repeatFrom, DateTime.Today.AddYears(-i));
                    Person t3 = new Person(i, repeatTo, DateTime.Today.AddYears(-i));
                    FinancialTransaction tr3 = new FinancialTransaction(f3, t3, amount);
                    transactions.Add(tr3);
                }
                else
                {
                    Person f4 = new Person(i, FromList[i], DateTime.Today.AddYears(-i));
                    Person t4 = new Person(i, ToList[i], DateTime.Today.AddYears(-i));
                    FinancialTransaction tr4 = new FinancialTransaction(f4, t4, amount);
                    transactions.Add(tr4);
                }
            }
            return transactions;
        }
    }
}
