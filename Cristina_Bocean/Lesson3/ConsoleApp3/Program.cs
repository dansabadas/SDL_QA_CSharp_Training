using System;
using System.Collections;

namespace ConsoleApp3
{
    public class Student
    {
        public int id;
        public string name;
        public DateTime dateOfBirth;
    }
    public interface IStudentRepository
    {
        ArrayList CreateAllStudents();
        ArrayList CreateAllStudents2();
    }
    public class StudentRepository : IStudentRepository
    {
        public string nameOfRepository = "whatever";
        public ArrayList CreateAllStudents()
        {
            //return an array list populated with 100 student           

            ArrayList myList = new ArrayList();
            int iterator = 0;
            while (iterator < 100)
            {
                Student st = new Student();
                st.id = iterator;
                st.name = "Cris " + iterator;
                st.dateOfBirth = DateTime.Today.AddYears(-iterator);
                myList.Add(st);
                iterator++;
            }
            return myList;
        }

        public ArrayList CreateAllStudents2()
        {
            //return an array list populated with 100 student           

            ArrayList myList = new ArrayList();
            int iterator = 0;
            while (iterator < 100)
            {
                Student st = new Student();
                st.id = iterator;
                st.name = "Cris " + iterator;
                st.dateOfBirth = DateTime.Today.AddYears(-iterator);
                if (iterator % 2 == 0)
                {
                    myList.Add(st);
                }
                iterator++;
            }
            return myList;
        }
    }

    public class Point2D
    {
        protected double _x; //changed the access modifier from private to protected to be able to access it in the derived class - point3D
        protected double _y;

        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0)
                    _x = -value;
                else
                    _x = _x + 10;
            }
        }

        public double Y => _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {
            return $"({_x}, {_y})";
        }

        public double CalculateDistanceTo(Point2D secondPoint2D)
        {
            double distance = Math.Sqrt(Math.Pow((secondPoint2D._x - _x), 2) + Math.Pow((secondPoint2D._y - _y), 2));
            return distance;
        }
    }
    public class Point3D : Point2D
    {
        private double _z;
        public Point3D(double x, double y, double z) : base(x, y)
        {
            _z = z;
        }
        public double Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }
        public override string ToString()
        {
            return $"({_x}, {_y},{_z})";
        }
        public double CalculateDistanceTo(Point3D secondPoint3D)
        {
            double distance = Math.Sqrt(Math.Pow((secondPoint3D._x - _x), 2) + Math.Pow((secondPoint3D._y - _y), 2) + Math.Pow((secondPoint3D._z - _z), 2));
            return distance;
        }
    }

    public interface IGeometryFactory
    {
        ArrayList GetMyPoints();
        Point2D GetRandomPoint(int a, int b);
        Point3D GetRandomPoint(int a, int b, int c);
    }

    public class GFactory : IGeometryFactory
    {
        public ArrayList GetMyPoints()
        {
            ArrayList myList = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Random r = new Random();

                Point2D coord = new Point2D(r.NextDouble() * 10, r.NextDouble() * 10);

                myList.Add(coord);
            }
            return myList;
        }

        public Point2D GetRandomPoint(int maxX, int maxY)
        {
            Random r = new Random();
            Point2D coord = new Point2D(r.NextDouble() * maxX, r.NextDouble() * maxY);
            return coord;
        }

        public Point3D GetRandomPoint(int maxX, int maxY, int maxZ)
        {
            Random r = new Random();
            Point3D coord = new Point3D(r.NextDouble() * maxX, r.NextDouble() * maxY, r.NextDouble() * maxZ);
            return coord;
        }
    }

    public abstract class Animal
    {
        protected int _id;
        protected string _name;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        protected Animal(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return $"ID= {_id}, Name= {_name}";
        }
    }

    public class Pig : Animal
    {
        public int Weight { get; set; }

        public Pig(int id, string name, int weight) : base(id, name)
        {
            Weight = weight;
        }
        public override string ToString()
        {
            return $"Pig " + base.ToString();
        }
    }
    public class Dog : Animal
    {
        public int EnemiesBitten { get; set; }

        public Dog(int id, string name, int enemiesBitten) : base(id, name)
        {
            EnemiesBitten = enemiesBitten;
        }

        public override string ToString()
        {
            return $"Dog " + base.ToString();
        }
    }

    public class Cat : Animal
    {
        public int MiceKilled { get; set; }

        public Cat(int id, string name, int miceKilled) : base(id, name)
        {
            MiceKilled = miceKilled;
        }
        public override string ToString()
        {
            return $"Cat " + base.ToString();
        }
    }
    public class Cow : Animal
    {
        protected int _milkProduced;
        public int MilkProduced
        {
            get
            {
                return _milkProduced;
            }
            set
            {
                _milkProduced = value;
            }
        }

        public Cow(int id, string name, int milkProduced) : base(id, name)
        {
            _milkProduced = milkProduced;
        }

        public override string ToString()
        {
            return $"Cow " + base.ToString();
        }
    }

    public class AnimalFarm
    {
        public ArrayList GenerateAnimals()
        {
            ArrayList animals = new ArrayList();
            Random r = new Random();
            int i = 0;

            while (i < 100)
            {
                int id = r.Next(0,1000);
                int genre = id % 4;
                int weight = r.Next(1, 100) % 30;
                int enemiesBitten = r.Next(1, 100) % 20;
                int miceKilled = r.Next(1, 100) % 70;
                int milkProduced = r.Next(1, 100) % 25;

                switch (genre)
                {
                    case 0:
                        Pig pig = new Pig(id, "Pig", weight);
                        animals.Add(pig);
                        break;
                    case 1:
                        Dog dog = new Dog(id, "Dog", enemiesBitten);
                        animals.Add(dog); ;
                        break;
                    case 2:
                        Cat cat = new Cat(id, "Cat", miceKilled);
                        animals.Add(cat); ;
                        break;
                    case 3:
                        Cow cow = new Cow(id, "Cow", milkProduced);
                        animals.Add(cow); ;
                        break;
                    default:
                        Console.WriteLine("Unknown animal.");
                        break;
                }
                i++;
            }
            return animals;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Cris!");

            IStudentRepository sr = new StudentRepository();
            //you can see only the members from interface => nameOfRepository is not visible when using the dot notation on sr (sr.)

            ArrayList myList = sr.CreateAllStudents2();
            foreach (Student st in myList)
            {
                Console.WriteLine(st.id + " " + st.name + " " + st.dateOfBirth);
                Console.WriteLine(st);
            }
            IGeometryFactory myFactoryPoint = new GFactory();
            ArrayList pointList = new ArrayList();
            pointList = myFactoryPoint.GetMyPoints();
            foreach (Point2D point in pointList)
            {
                Console.WriteLine($"({point.X}, {point.Y})");
            }

            var first2D = myFactoryPoint.GetRandomPoint(2, 3);

            Console.WriteLine($"({first2D.X}, {first2D.Y})");

            Console.WriteLine(first2D.ToString());

            // first2D.Y = 1000; cannot assign a value because the property declared like this "public double Y => _y;" is read-only 
            Point2D second2D = new Point2D(10, 20);
            second2D.X = -30;
            Console.WriteLine(second2D.X);     // 30
            second2D.X = 50;                   // 30+10
            Console.WriteLine(second2D.X);
            Point3D third2D = new Point3D(10, 20, 30);
            Console.WriteLine($"{third2D.X},{third2D.Y},{third2D.Z}");
            var first3D = myFactoryPoint.GetRandomPoint(100, 200, 300);
            Console.WriteLine($"{first3D.ToString()}");
            Console.WriteLine($"{first3D}");

            // Homework: 
            // Calculate the physical distance between two 2D points

            var myFirstPoint2d = myFactoryPoint.GetRandomPoint(2, 3);
            var mySecondPoint2d = myFactoryPoint.GetRandomPoint(4, 5);
            var distance2D = myFirstPoint2d.CalculateDistanceTo(mySecondPoint2d);
            Console.WriteLine($"The distance between A{myFirstPoint2d} and B{mySecondPoint2d} is D= {distance2D}");

            // Calculate the physical distance between two 3D points

            var myFirstPoint3d = myFactoryPoint.GetRandomPoint(2, 3, 4);
            var mySecondPoint3d = myFactoryPoint.GetRandomPoint(4, 5, 8);
            var distance3D = myFirstPoint3d.CalculateDistanceTo(mySecondPoint3d);
            Console.WriteLine($"The distance between A{myFirstPoint3d} and B{mySecondPoint3d} is D= {distance3D}");

            // Animal Farm

            AnimalFarm myFarm = new AnimalFarm();
            ArrayList myAnimals = new ArrayList();
            myAnimals = myFarm.GenerateAnimals();

            foreach (Animal animal in myAnimals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
