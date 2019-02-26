using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public enum WheelSize
    {
        Small, Medium, Big
    }
    public class Wheel
    {
        public string Name { get; }
        
        public WheelSize Size { get; }

        public Wheel(string name, WheelSize size)
        {
            Name = name;
            Size = size;
        }
    }
}
