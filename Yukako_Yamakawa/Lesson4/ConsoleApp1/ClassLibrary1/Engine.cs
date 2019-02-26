using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Engine
    {
        public string Name { get; }

        public int HoursePower { get; }

        public Engine(string name, int power)
        {
            Name = name;
            HoursePower = power;
        }
    }
}
