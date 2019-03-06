using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Person
    {
        public int Id { get; }
        public string Name { get; set; }
        public DateTime BirthDate { get; }

        public Person(int id, string name, DateTime birthDate)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
        }

    }
}
