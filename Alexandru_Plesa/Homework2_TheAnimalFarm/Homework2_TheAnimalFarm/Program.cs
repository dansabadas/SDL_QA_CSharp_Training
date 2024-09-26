using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_TheAnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFarm animalFarm = new AnimalFarm();
            ArrayList animalsInFarm = animalFarm.GenerateAnimals(10);

            foreach (Animal animal in animalsInFarm)
            {
                Console.WriteLine(animal);
            }

            Console.ReadLine();
        }
    }
}
