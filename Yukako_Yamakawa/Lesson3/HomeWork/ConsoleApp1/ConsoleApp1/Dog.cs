using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog : Animal // derived from Animal - dog is an animal
    {

        private int _enemiesBItten;

        public int EnemiesBitten
        {
            get { return _enemiesBItten; }
            set { _enemiesBItten = value; }
        }
        public Dog(int id, string name, int enemiesBitted) : base(id, name)
        {
            _enemiesBItten = enemiesBitted;
        }

        public override string ToString()
        {
            return "Dog " + base.ToString();
        }
    }
}
