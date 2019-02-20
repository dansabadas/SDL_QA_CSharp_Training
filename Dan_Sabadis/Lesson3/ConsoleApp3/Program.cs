using System;
using System.Collections;

namespace ConsoleApp3
{
    public class Student
    {
        public int Id;
        public string Name;
        public DateTime DateOfBirth;
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
            ArrayList myList = new ArrayList();
            int iterator = 0;
            while (iterator < 100)
            {
                Student myStudent = new Student();
                myStudent.Id = iterator;
                myStudent.Name = "student name " + iterator;
                myStudent.DateOfBirth = DateTime.Today.AddYears(-iterator);
                myList.Add(myStudent);
                iterator++;
            }

            // return an array list with 100 students
            return myList;
        }

        public ArrayList CreateAllStudents2()
        {
            ArrayList myList = new ArrayList();
            int iterator = 0;
            while (iterator < 100)
            {
                Student myStudent = new Student();
                myStudent.Id = iterator;
                myStudent.Name = "student name " + iterator;
                myStudent.DateOfBirth = DateTime.Today.AddYears(-iterator);
                if (iterator % 2 == 0)
                {
                    myList.Add(myStudent);
                }

                iterator++;
            }

            // return an array list with 100 students
            return myList;
        }
    }

    public class Point3D : Point2D
    {
        private double _z;
        public Point3D(double x, double y, double z) : base(x, y)
        {
            _z = z;
        }

        public override string ToString()
        {
            return $"[{_x},{this._y},{_z}]";
        }
    }

    public class Point2D
    {
        protected double _x;

        public double X // this is a property
        {
            get { return _x; }
            set
            {
                if (value < 0)
                {
                    _x = -value;
                }
                else
                {
                    _x = value + 10;
                }
            }
        }

        //public double X()
        //{
        //    return _x;
        //}

        protected double _y;
        public double Y => _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"({_x},{this._y})";
        }
    }

    public interface IGeometryFactory
    {
        ArrayList GetMyPoints();
        Point2D GetRandomPoint(int maxX, int maxY);
        Point3D GetRandomPoint(int maxX, int maxY, int maxZ);
    }

    public class GeometryFactory : IGeometryFactory
    {

        public ArrayList GetMyPoints()
        {
            ArrayList myArrayList = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random(i);
                Point2D aPoint = new Point2D(random.NextDouble()*10, random.NextDouble()*10);

                myArrayList.Add(aPoint);
            }

            return myArrayList;
        }

        public Point2D GetRandomPoint(int maxX, int maxY)
        {
            Random random = new Random();
            Point2D aPoint = new Point2D(random.NextDouble() * maxX, random.NextDouble() * maxY);

            return aPoint;
        }

        public Point3D GetRandomPoint(int maxX, int maxY, int maxZ)
        {
            Random random = new Random();
            Point3D aPoint = new Point3D(
                random.NextDouble() * maxX, 
                random.NextDouble() * maxY, 
                random.NextDouble() * maxZ);

            return aPoint;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository myRepository = new StudentRepository();
            
            ArrayList myList = myRepository.CreateAllStudents2();
           // myRepository.
            //for - print for each student their name and date of birth
            foreach (Student student in myList)
            {
                Console.WriteLine(student.Name + " " + student.DateOfBirth);
                Console.WriteLine(student.ToString());
            }

            IGeometryFactory myFactoryOfPoint = new GeometryFactory();
            ArrayList pointsList = myFactoryOfPoint.GetMyPoints();
            foreach (Point2D point in pointsList)
            {
                Console.WriteLine(point.ToString());
            }

            var myPoint1 = myFactoryOfPoint.GetRandomPoint(200, 300);
           //myPoint1.X = 1000000;
            Console.WriteLine(myPoint1.ToString());
            Console.WriteLine(myPoint1.X + " " + myPoint1.Y);
            Console.WriteLine("Hello lesson 3!");

            Point2D p2 = new Point2D(10, 20);
            p2.X = -30;
            Console.WriteLine(p2.ToString());
            p2.X = 100;
            Console.WriteLine(p2.ToString());

            var myPoint3 = myFactoryOfPoint.GetRandomPoint(200, 300, 400);
            Console.WriteLine(myPoint3.ToString());
            Console.WriteLine(myPoint3);
        }
    }
}
