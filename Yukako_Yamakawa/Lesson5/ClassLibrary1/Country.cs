using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Country
    {
        public int Id { get; }
        public string Name { get; }
        public Country(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"({Id}, {Name})";
        }
    }
}
