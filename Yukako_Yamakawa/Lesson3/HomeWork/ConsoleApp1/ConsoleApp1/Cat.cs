using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat : Animal // derived from Animal - dog is an animal
    {
        public int _miceKilled;
        public int MiceKilled
        {
            get { return _miceKilled; }
            set { _miceKilled = value; }
        }
        public Cat(int id, string name, int miceKilled) : base(id, name)
        {
            _miceKilled = miceKilled;
        }

        public override string ToString()
        {
            return "Cat " + base.ToString();
        }
    }
}
