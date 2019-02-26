using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public interface IAnimal
    {
        int id { get; }
    }

    public   abstract class Animal : IAnimal
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"{ id}" ;
        }
    }

    public class Pig : Animal
    {
        public override string ToString()
        {
            return $"Pig {name}"+base.ToString();
        }
    }
}
