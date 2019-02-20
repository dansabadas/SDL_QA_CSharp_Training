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
        public int Id;
        public string Name;
        public DateTime DateOfBirth;
    }

    public class StudentRepository
    {
        public ArrayList createAllStudents()
        {
            ArrayList ListOfStudents = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                Student mystudent = new Student();
                mystudent.Id = i;
                mystudent.Name = "Ligia" + i;
                mystudent.DateOfBirth = DateTime.Today.AddYears(-i);
                ListOfStudents.Add(mystudent);

            }
            return ListOfStudents;
        }
        public ArrayList createAllStudents2()
        {
            ArrayList ListOfStudents = new ArrayList();
            for (int i = 0; i < 100; i += 2)
            {
                Student mystudent = new Student();
                mystudent.Id = i;
                mystudent.Name = "Ligia" + i;
                mystudent.DateOfBirth = DateTime.Today.AddYears(-i);
                ListOfStudents.Add(mystudent);

            }
            return ListOfStudents;
        }
    }
    public class Point2d
    {
        protected double _x;
        public double X//this is a property
        {
            get { return _x; }
            
        }
        public double Y
        {
            get { return _y; }
        }
       protected double _y;
        public Point2d(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"({_x},{_y})";
        }


    }
    public class Point3d: Point2d
    {
        private double _z;
        public Point3d(double x, double y,double z): base(x,y)
        {
            _z = z;
        }
        public override string ToString()
        {
            return $"({_x},{_y}, {_z})";
        }

    }
    public interface IGeometryFactory
    {
        ArrayList GetMyPoints();
        Point2d GetRandomPoint(int maxX, int maxY);
        Point3d GetRandomPoint(int maxX, int maxY, int maxZ);
    }
    public class GeometryFactory : IGeometryFactory
    {

        public ArrayList GetMyPoints()
        {
            ArrayList MyArrayList = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random(i);
                Point2d aPoint = new Point2d(random.NextDouble() * 10, random.NextDouble() * 10);
                MyArrayList.Add(aPoint);
            }
            return MyArrayList;
        }
        public Point2d GetRandomPoint(int maxX, int maxY)
        {
            Random random = new Random();
            Point2d aPoint = new Point2d(random.NextDouble() * maxX, random.NextDouble() * maxY);

            return aPoint;
        }
        public Point3d GetRandomPoint(int maxX, int maxY, int maxZ)
        {
            Random random = new Random();
            Point3d aPoint = new Point3d(random.NextDouble() * maxX, random.NextDouble() * maxY, random.NextDouble()*maxZ);

            return aPoint;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");

            StudentRepository myRepository= new StudentRepository();
            ArrayList myList = myRepository.createAllStudents2();
            foreach (Student student in myList)
            {
                Console.WriteLine(student.Name + " " + student.DateOfBirth);
            }
            IGeometryFactory myFactoryOfPoint = new GeometryFactory();
            ArrayList PointList = myFactoryOfPoint.GetMyPoints();
            
                foreach(Point2d point in PointList)
                {
                    Console.WriteLine(value: $"({point.X},{point.Y})");
                }

            var myPoint1 = myFactoryOfPoint.GetRandomPoint(2,3);
            Console.WriteLine(myPoint1.ToString());
            var myPoint2 = myFactoryOfPoint.GetRandomPoint(200, 300, 400);
            Console.WriteLine(myPoint2.ToString());
            
            Console.ReadKey();
        }
    }
}
