using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace AnimalFarm
{


    public abstract class Animal
    {
        static void Main(string[] args)
        {
            ArrayList animals = new ArrayList();
            var animFarm = new Animal_Farm();
            animals = animFarm.Generate_Animals();

            for (int i = 0; i < 100; i++)
            {
                var a = animals[i] as Animal;

                Console.WriteLine(a.ToString());
            }
        }
        protected int Id;
        protected string Name;

        protected Animal(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"({Id},{Name})";
        }
    }

    public class Pig : Animal
    {
        private int _weight;

        public int Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public Pig(int id, string name, int weight) : base(id, name)
        {
            _weight = weight;
        }

        public override string ToString()
        {
            return "Pig" + base.ToString();
        }
    }

    public class Dog : Animal
    {
        private int _enemiesBitten;

        public int EnemiesBitten
        {
            get => _enemiesBitten;
            set => _enemiesBitten = value;

        }

        public Dog(int id, string name, int enemiesBitten) : base(id, name)
        {
            _enemiesBitten = enemiesBitten;
        }

        public override string ToString()
        {
            return "Dog" + base.ToString();
        }
    }

    public class Cat : Animal
    {
        private int _miceKilled;

        public int MiceKilled
        {
            get => _miceKilled;
            set => _miceKilled = value;
        }

        public Cat(int id, string name, int miceKilled) : base(id, name)
        {
            _miceKilled = miceKilled;
        }

        public override string ToString()
        {
            return "Cat" + base.ToString();
        }
    }


    public class Cow : Animal
    {
        private int _milkProduced;

        public int MilkProduced
        {
            get => _milkProduced;
            set => _milkProduced = value;
        }
        public Cow(int id, string name, int milkProduced) : base(id, name)
        {
            _milkProduced = milkProduced;
        }

        public override string ToString()
        {
            return "Cow" + base.ToString();
        }

    }


    public class Animal_Farm
    {
        public ArrayList Generate_Animals()
        {
            ArrayList animalList = new ArrayList();

            for (int i = 0; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    Pig pig = new Pig(i, "porc" + i, i + 1);
                    animalList.Add(pig);
                    pig.ToString();
                }

                if (i % 4 == 1)
                {
                    Dog dog = new Dog(i, "caine" + i, i);
                    animalList.Add(dog);
                    dog.ToString();
                }

                if (i % 4 == 2)
                {
                    var pisi = new Cat(i, "pisi" + i, i);
                    animalList.Add(pisi);
                    pisi.ToString();
                }

                if (i % 4 == 3)
                {
                    var vaca = new Cow(i, "vaca" + i, i);
                    animalList.Add(vaca);
                    vaca.ToString();
                }

            }

            return animalList;
        }
    }
}
