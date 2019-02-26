using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Person
    {
        public int Id { get; }
        public string Name { get; }
        public DateTime BirthDate { get; }
        public static double Ballance { get; set; }

        public Person (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
