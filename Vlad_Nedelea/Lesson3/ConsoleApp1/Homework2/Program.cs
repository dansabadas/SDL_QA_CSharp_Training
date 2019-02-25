using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public abstract class Animal
    {
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
            return "Pig"+base.ToString();
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

            for(int i = 0; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    Pig pig = new Pig(i, "porc"+i, i+1);
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
                    var pisi = new Cat(i, "pisi"+i, i);
                    animalList.Add(pisi);
                    pisi.ToString();
                }

                if (i % 4 == 3)
                {
                    var vaca = new Cow(i, "vaca"+i, i);
                    animalList.Add(vaca);
                    vaca.ToString();
                }

            }

            return animalList;
        }
    }

    public class Point2D
    {
        public Point2D() { }
        public double X { get { return _x; } set { _x = value; } }
        public double Y { get { return _y; } set { _y = value; } }

        private double _x;
        private double _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {
            return $"(x:{_x},y:{_y})";
        }
    }

    public class Point3D : Point2D
    {
        private double _z;

        public double Z
        {
            get => _z;
            set => _z = value;
        }
        public Point3D(double x, double y, double z) : base(x, y)
        {
            _z = z;
        }
    }

    public interface IGeometryFactory
    {
        double GetDistance2Points_2D(Point2D first, Point2D second);
        double GetDistance2Points_3D(Point3D first, Point3D second);
    }

    public class Implementation : IGeometryFactory
    {
        public double GetDistance2Points_2D(Point2D firstPoint, Point2D secondPoint)
        {
           return Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2));
        }

        public double GetDistance2Points_3D(Point3D firstPoint, Point3D secondPoint)
        {
           return  Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2) + Math.Pow((firstPoint.Z - secondPoint.Z), 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList animals = new ArrayList();
            var test = new Animal_Farm();
            animals=test.Generate_Animals();

            for(int i = 0; i < 100; i++)
            {
                var anim = animals[i] as Animal;

                Console.WriteLine(anim.ToString());
            }
        }
    }
}
