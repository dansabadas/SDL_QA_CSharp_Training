using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_TheAnimalFarm
{
    public class Cow : Animal
    {
        int MilkProduced { get; set; }

        public Cow(int Id, string Name, int milkProduced) : base(Id, Name)
        {
            MilkProduced = milkProduced;
        }

        public override string ToString()
        {
            return "Cow: " + base.ToString() + "Milk Produced: " + MilkProduced;
        }
    }
}
