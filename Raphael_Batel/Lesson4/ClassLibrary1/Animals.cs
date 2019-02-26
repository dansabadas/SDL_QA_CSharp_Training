using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IAnimal
    {
        int Id { get; }
    }

    public abstract class Animal : IAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Animal {Id}";
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
