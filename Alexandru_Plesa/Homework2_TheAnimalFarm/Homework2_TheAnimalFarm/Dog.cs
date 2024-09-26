using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_TheAnimalFarm
{
    public class Dog : Animal
    {
        int EnemiesBitten { get; set; }

        public Dog(int Id, string Name, int enemiesBitten) : base(Id, Name)
        {
            EnemiesBitten = enemiesBitten;
        }

        public override string ToString()
        {
            return "Dog " + base.ToString() + "Enemies Bitten: " + EnemiesBitten;
        }
    }
}
