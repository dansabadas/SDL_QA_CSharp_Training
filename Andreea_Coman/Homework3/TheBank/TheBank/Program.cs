using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBank
{
    interface IBank
    {
        ArrayList GenerateFinancialTransactions(int TrNumber);
    }

    public class Person
    {


        int Id { get; }
        string Name { get; }
        // DateTime BirthDay { get; }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return $" {Name} ";
        }
    }

    public class FinancialTransaction : Person
    {

        double Amount { get; }

        private Person FromPerson { get; }
        private Person ToPerson { get; }
        public FinancialTransaction(int id, string name) : base(id, name) { }

        public override string ToString()
        {
            return $"{Amount} , {FromPerson} , {ToPerson}";
        }
    }

    internal class Bank : IBank
    {
        public ArrayList GenerateFinancialTransactions(int TrNumber)
        {
            // creez un array cu o lista de tranzactii, formate din suma, destinatar si expeditor

            ArrayList Transaction = new ArrayList();
            for (int k = 0; k < TrNumber; k++)
            {
                Random suma = new Random();
                double amount = suma.Next(100, 200);
                Transaction.Add(amount);

                for (int i = 0; i < 5; i++)

                {
                    Person personaFrom = new Person(11, "john" + i);
                    Transaction.Add(personaFrom);
                }
                for (int j = 0; j < 3; j++)
                {
                    Person personaTo = new Person(12, "dick" + j);
                    Transaction.Add(personaTo);

                }
                Console.WriteLine(Transaction.ToString());
            }

                return Transaction;
        }
    }
}      


    class Program
    {
        static void Main(string[] args)
        {
            IBank myBank = new Bank();
            ArrayList myList = myBank.GenerateFinancialTransactions(10);
            Console.WriteLine($"{myList.ToString()}");
            
            {
                Console.WriteLine("suntem in progr pp");
                //Console.WriteLine($"{Amount} dollars come from {personaFrom}, will be received by {personaTo}");

                Console.ReadKey();
            }
        }
    }


          