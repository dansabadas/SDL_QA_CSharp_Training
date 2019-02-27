using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    enum WhellSize
    {
        small,
        medium,
        big
    }
    class Wheel
    {
        public string Name { get; }
        public WhellSize Size { get; set; }

        public Wheel(string name, WhellSize size)
        {
            Name = name;
            Size = size;
        }
    }
}
