using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car
    {
        public Car(string name)
        {
            Name = name;
            Wheels = new Wheel[4];
        }

        public string Name { get; }
        public Engine Engine { get; set; }
        public Wheel[] Wheels { get; set; }
    }
}
