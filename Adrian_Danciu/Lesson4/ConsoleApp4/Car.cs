using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Car
    {
        public string Name { get; }
        public Engine Engine { get; set; }


        public Car (string name, Engine engine)
        {
            Name = name;
            Engine = engine;
        }
        
        public Wheel[] Wheels
        {
            get; set;
        }
    }
}
