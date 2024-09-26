using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_TheAnimalFarm
{
    public class Pig : Animal
    {
        int Weight { get; set; }


        public Pig(int Id, string Name, int weight) : base(Id, Name)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return "Pig " + base.ToString() + "Weight: " + Weight;
        }
    }
}
