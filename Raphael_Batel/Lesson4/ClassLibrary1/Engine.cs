using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Engine
    {
        public Engine(string name, int hp)
        {
            Name = name;
            HP = hp;
        }

        public string Name { get; }
        public int HP { get; }
    }
}
