using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList animals = AnimalFarm.GenerateAnimals();
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }

    class AnimalFarm
    {
        public static ArrayList GenerateAnimals()
        {
            Random rand = new Random();
            ArrayList animals = new ArrayList();
            for(int i = 1; i < 100; i++)
            {
                int remainder = i % 4;
                Animal animal;
                switch (remainder)
                {
                    case 0:
                        animal = new Pig(i, "Piggy", rand.Next(200));
                        break;
                    case 1:
                        animal = new Dog(i, "Doggo", rand.Next(50));
                        break;
                    case 2:
                        animal = new Cat(i, "Mauzi", rand.Next(1000));
                        break;
                    case 3:
                        animal = new Cow(i, "Frieda", rand.Next(600));
                        break;
                    default:
                        throw new Exception("This should never happen.");
                }
                animals.Add(animal);
            }
            return animals;
        }
    }

    abstract class Animal
    {
        protected int ID { get; set; }
        protected string Name { get; set; }

        protected Animal()
        {

        }

        protected Animal(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {ID} \nName: {Name}";
        }
    }

    class Pig : Animal
    {
        public int Weight { get; set; }

        public Pig(int id, string name, int weight) : base (id, name)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return "Pig\n" + base.ToString();
        }
    }

    class  Dog : Animal
    {
        public int EnemiesBitten { get; set; }

        public Dog(int id, string name, int enemiesBitten) : base(id, name)
        {
            EnemiesBitten = enemiesBitten;
        }

        public override string ToString()
        {
            return "Dog\n" + base.ToString();
        }
    }

    class Cat : Animal
    {
        public int MiceKilled { get; set; }

        public Cat(int id, string name, int miceKilled) : base(id, name)
        {
            MiceKilled = miceKilled;
        }

        public override string ToString()
        {
            return "Cat\n" + base.ToString();
        }
    }

    class Cow : Animal
    {
        public int MilkProduced { get; set; }

        public Cow(int id, string name, int milkProduced) : base(id, name)
        {
            MilkProduced = milkProduced;
        }
        public override string ToString()
        {
            return "Cow\n" + base.ToString();
        }
    }
}
