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

        //if interface method is written, it would work for the abstruct class
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

    public class Pig : Animal  //inherit only one class, but can have multiple interfaces can be implemented
    {
        public override string ToString()
        {
            return $"Pig {Name} " + base.ToString();
        }
    } 
}
