using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Person
    {
        public int ID { get; }
        public string Name { get; }
        public DateTime BirthDate { get; }

        public Person (int id, string name, DateTime birthDate)
            {
                ID = id;
                Name = name;
                BirthDate = birthDate;
            }
    }
}
