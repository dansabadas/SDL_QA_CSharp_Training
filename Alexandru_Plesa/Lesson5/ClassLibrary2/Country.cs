using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Country
    {
        public int ID { get; }
        public string Name { get; }

        public Country(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }
}
