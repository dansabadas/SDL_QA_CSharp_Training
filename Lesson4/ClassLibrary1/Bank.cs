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
        ArrayList GenerateFinancialTransactions(int numberOfTransactions);
    }

    public class Bank : IBank
    {
        public ArrayList GenerateFinancialTransactions(int numberOfTransactions)
        {
            ArrayList GeneratedTransactions = new ArrayList();
            Person setReceiver = new Person(3, "'THE' Sender", new DateTime(1980, 10, 20));
            Person setSender = new Person(5, "'THE' Receiver", new DateTime(1990, 10, 20));
            Random random = new Random();
            for (int i = 1; i <= numberOfTransactions; i++)
            {
                string senderName = $"Sender{i}";
                int senderId = i;
                DateTime senderDOB = new DateTime((1950 + i), 10, 10);

                string receiverName = $"Reciever{i}";
                int receiverId = i * 2;
                DateTime reciverDOB = new DateTime((1970 + i), 5, 5);

                Person sender = new Person(senderId, senderName, senderDOB);
                Person receiver = new Person(receiverId, receiverName, reciverDOB);
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
}
