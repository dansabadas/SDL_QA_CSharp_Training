using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_TheAnimalFarm
{
    public class Cat : Animal
    {
        int MiceKilled { get; set; }

        public Cat(int Id, string Name, int miceKilled) : base(Id, Name)
        {
            MiceKilled = miceKilled;
        }

        public override string ToString()
        {
            return "Cat :" + base.ToString() + "Mice Killed: " + MiceKilled;
        }
    }
}
