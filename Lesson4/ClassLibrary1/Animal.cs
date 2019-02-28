using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IAnimal
    {
        int ID { get; }
    }

    public abstract class Animal : IAnimal
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Animal {ID}";
        }
    }

    public class Pig : Animal
    {
        public override string ToString()
        {
            return $"Pig {Name} " + base.ToString();
        }
    }

}
