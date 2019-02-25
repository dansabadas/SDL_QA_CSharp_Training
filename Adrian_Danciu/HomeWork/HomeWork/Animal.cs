using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public abstract class Animal
    {
        protected int ID { get; set; }
        protected string Name { get; set; }

        public Animal(int id, String name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{ID},{Name}";
        }

    }

    public class Pig : Animal
    {
        public int Weight { get; set; }

        public Pig(int id, String name, int weight) : base(id, name)
        {
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Pig: {ID},{Name},{Weight}";
        }
    }

    public class Dog : Animal
    {
        public int EnemiesBitten { get; set; }

        public Dog(int id, String name, int enemiesBitten) : base(id, name)
        {
            EnemiesBitten = enemiesBitten;
        }

        public override string ToString()
        {
            return $"Dog: {ID},{Name},{EnemiesBitten}";
        }
    }

    public class Cat : Animal
    {
        public int MiceKilled { get; set; }

        public Cat(int id, String name, int miceKilled) : base(id, name)
        {
            MiceKilled = miceKilled;
        }

        public override string ToString()
        {
            return $"Cat: {ID},{Name},{MiceKilled}";
        }
    }

    public class Cow : Animal
    {
        public int MilkProduced { get; set; }

        public Cow(int id, String name, int milkProduced) : base(id, name)
        {
            MilkProduced = milkProduced;
        }

        public override string ToString()
        {
            return $"Cow: {ID},{Name},{MilkProduced}";
        }
    }

    public class AnimalFarm
    {
        public ArrayList GenerateAnimals()
        {
            ArrayList myArrayList = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                Animal animal = null;
                switch (i % 4)
                {
                    case 0:
                        animal = new Pig(i, "pig" + i, new Random().Next(100, 200));
                        break;
                    case 1:
                        animal = new Dog(i, "dog" + i, new Random().Next(90, 100));
                        break;
                    case 2:
                        animal = new Cat(i, "cat" + i, new Random().Next(50, 70));
                        break;
                    case 3:
                        animal = new Cow(i, "cow" + i, new Random().Next(20, 30));
                        break;
                }
                myArrayList.Add(animal);
            }
            return myArrayList;
        }
    }
}

