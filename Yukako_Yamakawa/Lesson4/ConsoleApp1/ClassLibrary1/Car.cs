using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car
    {
        public string Name { get; }

        public Engine Engine { get; set; }  //engine can be replaced

        public Wheel[] Wheels
        {
            get;
            set;
        }

        public Car(string name)
        {
            Name = name;
            Wheels = new Wheel[4];
        }
    }
}
