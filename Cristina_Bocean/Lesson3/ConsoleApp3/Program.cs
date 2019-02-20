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

    public class point2D
    {
        protected double _x;
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
       
       // public double Y => _y;
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {
            return $"({_x}, {_y})";
        }
    }
    public class Point3D :point2D
    {
        private double _z;
        public Point3D(double x, double y, double z): base(x,y)
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

    }

    public interface IGeometryFactory
    {
        ArrayList GetMyPoints();
        point2D GetRandomPoint(int a, int b);
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

                point2D coord = new point2D(r.NextDouble() * 10, r.NextDouble() * 10);

                myList.Add(coord);
            }
            return myList;
        }

        public point2D GetRandomPoint(int maxX, int maxY)
        {
            Random r = new Random();
            point2D coord = new point2D(r.NextDouble() * maxX, r.NextDouble() * maxY);
            return coord;
        }

        public Point3D GetRandomPoint(int maxX, int maxY, int maxZ)
        {
            Random r = new Random();
            Point3D coord = new Point3D(r.NextDouble() * maxX, r.NextDouble() * maxY, r.NextDouble());
            return coord;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Cris!");

            IStudentRepository sr = new StudentRepository();
            //you can see only the members from interface => nameOfRepository is not visible in sr.

            ArrayList myList = sr.CreateAllStudents2();
            foreach (Student st in myList)
            {
                Console.WriteLine(st.id + " " + st.name + " " + st.dateOfBirth);
                Console.WriteLine(st);
            }
            IGeometryFactory myFactoryPoint = new GFactory();
            ArrayList pointList = new ArrayList();
            pointList = myFactoryPoint.GetMyPoints();
            foreach (point2D point in pointList)
            {
                Console.WriteLine($"({point.X}, {point.Y})");
            }

            var point2DList = myFactoryPoint.GetRandomPoint(2, 3);

            //Console.WriteLine($"({point2DList.X}, {point2DList.Y})");
            Console.WriteLine(point2DList.ToString());
            // point2DList.Y = 1000;
            point2D p = new point2D(10, 20);
            p.X = -30;
            Console.WriteLine(p.X);
            p.X = 100;
            Console.WriteLine(p.X);
            Point3D p3 = new Point3D(10, 20, 30);
            Console.WriteLine($"{p3.X},{p3.Y},{p3.Z}");
            var myPoint3 = myFactoryPoint.GetRandomPoint(100,200,300);
            Console.WriteLine($"{myPoint3.ToString()}");
            Console.WriteLine($"{myPoint3}");
        }
    }
}
