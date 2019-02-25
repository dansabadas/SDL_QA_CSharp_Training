using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Student
    {
       public string Name { get; set; }
       public DateTime DOB { get; set; }
       public int Id { get; set; }
    }

    public interface IStudentRepository
    {
        ArrayList CreateAllStudents();
        ArrayList CreateAllStudents2();
    }

    public class StudentRepository : IStudentRepository
    {
        public string NameOfRepository = "some name";
        public ArrayList CreateAllStudents()
        {
            int numberOfStudents = 100;
            ArrayList studentList = new ArrayList();
            for (int i = 0; i < numberOfStudents; i++)
            {
                Student student = new Student
                {
                    Name = "Student-" + (i + 1),
                    DOB = DateTime.Today.AddYears(i),
                    Id = i,
                };
                studentList.Add(student);
            }
            return studentList;
        }

        public ArrayList CreateAllStudents2()
        {
            int numberOfStudents = 100;
            ArrayList studentList = new ArrayList();
            for (int i = 0; i < numberOfStudents; i++)
            {
                if (i % 2 == 0)
                {
                    Student student = new Student
                    {
                        Name = "Even-Student-" + i,
                        DOB = DateTime.Today.AddYears(i),
                        Id = i,
                    };
                    studentList.Add(student);
                }
            }
            return studentList;
        }
    }

    public class Point3D : Point2D
    {
        protected double _z { get; set;  }
        public double Z
        {
            get { return _z; }
            set { }
        }
        public Point3D(double x, double y, double z) : base(x, y)
        {
            _z = z;
        }

        public override string ToString()
        {
            return $"X=({_x}), Y=({_y}), Z={_z}";
        }
    }

    public class Point2D
    {
        protected double _x { get; set; }
        protected double _y { get; set; }

        public double X
        {
            get { return _x; }
            set { }
        }

        public double Y
        {
            get { return _y; }
            set { }
        }

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"X=({_x}), Y=({_y})";
        }

    }

    public interface IGeometryFactory
    {
        ArrayList GetMyPoints();
        Point2D GetRandomPoint(int maxX, int maxY);
        Point3D GetRandomPoint3D();
        double GetDistanceBetweenTwoPoints2D(Point2D pointOne, Point2D pointTwo);
        double GetDistanceBetweenTwoPoints3D(Point3D pointOne, Point3D pointTwo);
    }

    public class GeometryFactory : IGeometryFactory
    {
        public Point3D GetRandomPoint3D()
        {
            Random random = new Random();
            Point3D point = new Point3D(random.NextDouble(), random.NextDouble(), random.NextDouble());
            return point;
        }

        public Point2D GetRandomPoint(int maxX, int maxY)
        {
            Random random = new Random();
            Point2D point = new Point2D(random.NextDouble(), random.NextDouble());
            return point;
        }

        public ArrayList GetMyPoints()
        {
            ArrayList points = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random(i);
                Point2D point = new Point2D(random.NextDouble(), random.NextDouble());
                points.Add(point);
            }
            return points;
        }

        public double GetDistanceBetweenTwoPoints2D (Point2D pointOne, Point2D pointTwo)
            // This method uses the Pythagorean theorem to calculate the distance between 2 Point2D 
        {
            double distance;
            double legA = pointOne.X - pointTwo.X;
            double legB = pointOne.Y - pointTwo.Y;
            distance = Math.Sqrt(Math.Pow(legA, 2) + Math.Pow(legB, 2));
            return distance;
        }

        public double GetDistanceBetweenTwoPoints3D(Point3D pointOne, Point3D pointTwo)
        {
            double distance = Math.Sqrt(Math.Pow((pointOne.X - pointTwo.X), 2) + Math.Pow((pointOne.Y - pointTwo.Y), 2) + Math.Pow((pointOne.Z - pointTwo.Z), 2));
            return distance;
        }
    }

    public abstract class Animal
    {
        public string Name { get; set; }
        public int ID { get; set; }

        protected Animal(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public override string ToString()
        {
            return $"Name {Name}, ID {ID}";
        }
    }

    public class Pig : Animal 
    {
        public int Weight { get; set; }
        public Pig (string name, int id, int weight) : base (name, id)
        {
            ID = id;
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Pig {base.ToString()}" ;
        }
    }

    public class Dog : Animal
    {
        public int EnemiesBitten { get; set; }
        public Dog (string name, int id, int enemiesBitten) : base (name, id)
        {
            Name = name;
            ID = id;
            EnemiesBitten = enemiesBitten;
        }

        public override string ToString()
        {
            return $"Dog {base.ToString()}";
        }
    }

    public class Cat : Animal
    {
        public int MiceKilled { get; set; }
        public Cat (string name, int id, int miceKilled) : base (name, id)
        {
            Name = name;
            ID = id;
            MiceKilled = miceKilled;
        }

        public override string ToString()
        {
            return $"Cat {base.ToString()}";
        }
    }

    public class Cow : Animal
    {
        public int MilkProduced { get; set; }
        public Cow (string name, int id, int milkProduced) : base (name, id)
        {
            Name = name;
            ID = id;
            MilkProduced = milkProduced;
        }

        public override string ToString()
        {
            return $"Cow {base.ToString()}";
        }
    }

    public class AnimalFarm
    {
        public ArrayList GenerateAnimals (int numberOfAnimals)
        {
            ArrayList animals = new ArrayList();
            Random random = new Random();
            for (int i = 0; i < numberOfAnimals; i++)
            {
                if (i % 4 == 0)
                {
                    int weight = random.Next(200);
                    animals.Add(new Pig("Pig", (i + 1), weight));
                }
                else if (i % 4 == 1)
                {
                    int enemiesBitten = random.Next(10);
                    animals.Add(new Dog("Dog", (i + 1), enemiesBitten));
                }
                else if (i % 4 == 2)
                {
                    int miceKilled = random.Next(25);
                    animals.Add(new Cat("Cat", (i + 1), miceKilled));
                }
                else if (i % 4 == 3)
                {
                    int milkProduced = random.Next(10);
                    animals.Add(new Cow("Cow", (i + 1), milkProduced));
                }
            }
            return animals;
        }
    }

    class Lesson3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lesson 3!");
            IStudentRepository studentRepository = new StudentRepository();
            ArrayList myList = studentRepository.CreateAllStudents();
            foreach(Student student in myList)
            {
                Console.WriteLine(student.Name + " " + student.DOB);
                Console.WriteLine(student.ToString());
            }
            ArrayList evenList = studentRepository.CreateAllStudents2();
            foreach (Student student in evenList)
            {
                Console.WriteLine(student.Name + " " + student.DOB);
            }

            IGeometryFactory geometryFactory = new GeometryFactory();
            var points = geometryFactory.GetMyPoints();
            foreach (Point2D p in points)
            {
                Console.WriteLine(p.ToString());
            }
            var point = geometryFactory.GetRandomPoint(2, 15);
            Console.WriteLine(point.ToString());

            Point2D p2 = new Point2D(10, 20);
            p2.X = 30;
            Console.WriteLine(p2.ToString());

            Point3D p3d = geometryFactory.GetRandomPoint3D();
            Console.WriteLine(p3d.ToString());
            Console.WriteLine(p3d);

            Console.WriteLine(geometryFactory.GetDistanceBetweenTwoPoints2D(new Point2D(1, 3), new Point2D(2, -1)));

            Console.WriteLine(geometryFactory.GetDistanceBetweenTwoPoints3D(new Point3D(1, 3, 5), new Point3D(1, 3, 9)));
            Console.WriteLine(geometryFactory.GetDistanceBetweenTwoPoints3D(new Point3D(1, 15, 5), new Point3D(1, 3, 5)));
            Console.WriteLine(geometryFactory.GetDistanceBetweenTwoPoints3D(new Point3D(1, 3, 5), new Point3D(-4, 3, 5)));
            Console.WriteLine(geometryFactory.GetDistanceBetweenTwoPoints3D(new Point3D(-1, -3, -5), new Point3D(1, 3, 5)));

            var animalFarm = new AnimalFarm();
            var animals = animalFarm.GenerateAnimals(100);
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine(animals[i].ToString());
            }

            Console.Read();
        }
    }
}
