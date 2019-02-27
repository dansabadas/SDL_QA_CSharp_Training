using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pig : Animal // derived from Animal - pig is an animal
    {
        private int _weight;
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Pig(int id, string name, int weight) : base(id, name)
        {
            _weight = weight;
        }

        public override string ToString()
        {
            return "Pig " + base.ToString();
        }

    }
}
