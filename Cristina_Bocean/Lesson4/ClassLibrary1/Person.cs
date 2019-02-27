using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public int ID { get; }
        public string Name { get; }
        public DateTime BirthDate { get; }

        public Person(int id, string name, DateTime birthdate)
        {
            ID = id;
            Name = name;
            BirthDate = birthdate;
        }
    }
}
