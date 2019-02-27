using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cow : Animal // derived from Animal - dog is an animal
    {
        public int _milkProduced;
        public int MilkProduced
        {
            get { return _milkProduced; }
            set { _milkProduced = value; }
        }
        public Cow(int id, string name, int milkProduced) : base(id, name)
        {
            _milkProduced = milkProduced;
        }

        public override string ToString()
        {
            return "Cow " + base.ToString();
        }
    }
}
