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
    public abstract class Animals : IAnimal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Animal {Id}";
        }
    }
    // abstract classes can have method implementation while interfaces cannot
    // multiple inheritance from multiple classes is not supported, only from interfaces
    public class Pig : Animals
    {
        public override string ToString()
        {
            return $"Pig {Name}" + base.ToString();
        }
    }
}
