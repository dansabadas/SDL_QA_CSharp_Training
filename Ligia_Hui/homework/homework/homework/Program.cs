using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        public class Person
        {
            public int Id { get; }
            public string Name { get; }
            public DateTime BirthDate { get; }

            public Person(int id, string name, DateTime birthDate)
            {
                Id = id;
                Name = name;
                BirthDate = birthDate;

            }
        }
        public class FinancialTransaction
        {
            public Person PersonFrom { get; set; }
            public Person PersonTo { get; set; }
            public double Ammount { get; set; }

            public FinancialTransaction(Person personFrom, Person personTo, double ammount)
            {
               PersonFrom = personFrom;
               PersonTo = personTo;
                Ammount = ammount;
            }

        }
        public interface IBank
        {
            ArrayList GenerateFinancialTransactions(int numberOfTransactions);
        }

        public class Bank : IBank
        {
            public ArrayList GenerateFinancialTransactions(int numberOfTransactions)
            {
                ArrayList GeneratedTransactions = new ArrayList();
                Person setReceiver = new Person(3, "Sender", new DateTime(1980, 10, 20));
                Person setSender = new Person(5, "Receiver", new DateTime(1990, 10, 20));
                Random random = new Random();
                for (int i = 1; i <= numberOfTransactions; i++)
                {
                    string senderName = $"Sender{i}";
                    int senderId = i;
                    DateTime senderRate = new DateTime((1950 + i), 10, 10);

                    string receiverName = $"Reciever{i}";
                    int receiverId = i * 2;
                    DateTime reciverRate = new DateTime((1970 + i), 5, 5);

                    Person sender = new Person(senderId, senderName, senderRate);
                    Person receiver = new Person(receiverId, receiverName, reciverRate);
                    if (i % 3 == 0)
                    {
                        receiver = setReceiver;
                    }
                    if (i % 5 == 0)
                    {
                        sender = setSender;
                    }
                    double amount = random.Next(100, 200);
                    FinancialTransaction transaction = new FinancialTransaction(sender, receiver, amount);
                    GeneratedTransactions.Add(transaction);
                }
                return GeneratedTransactions;
            }
        }

        static void Main(string[] args)
        {
            IBank Bank = new Bank();
            ArrayList transactions = Bank.GenerateFinancialTransactions(20);
            foreach (FinancialTransaction transaction in transactions)
            {
                Console.WriteLine(transaction.ToString());
            }

        }
    }
}
