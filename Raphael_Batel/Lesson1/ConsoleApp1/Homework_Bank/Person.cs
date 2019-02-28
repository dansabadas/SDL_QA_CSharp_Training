using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Bank
{
    class Person
    {
        public Person(int id, string name, DateTime birthDate)
        {
            ID = id;
            Name = name;
            BirthDate = birthDate;
        }

        public int ID { get; }
        public string Name { get; }
        public DateTime BirthDate { get; }
    }
}
