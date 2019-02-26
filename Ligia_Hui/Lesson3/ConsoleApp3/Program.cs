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
        public double Z
        {
            get { return _z; }
        }
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
        double GetDistanceBetweenTwoPoints(Point2d firstPonint2D, Point2d secondPoint2D);
        double GetDistanceBetweenThreePoints3d(Point3d firstPonint3D, Point3d secondPoint3D);
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
        public double GetDistanceBetweenTwoPoints (Point2d A, Point2d B)
        {
            double distance = Math.Sqrt(Math.Pow((A.X-B.X), 2) + Math.Pow((A.Y-B.Y), 2));
            return distance;
        }
        
        public double GetDistanceBetweenThreePoints3d(Point3d a, Point3d b)
        {
            double distance = Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2) + Math.Pow((a.Z - b.Z), 2));
            return distance;
        }
    }
    public abstract class Animal
    {
        protected int ID;
        protected string Name;
  
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
                Console.WriteLine(student.ToString());
            }

            ArrayList evenList = myRepository.createAllStudents2();
            foreach (Student student in evenList)
            {
                Console.WriteLine(student.Name + " " + student.DateOfBirth);
            }

            IGeometryFactory randomPoints = new GeometryFactory();
            ArrayList points = randomPoints.GetMyPoints();

            foreach (Point2d pnt in points)
            {
                Console.WriteLine(pnt.ToString());
            }

            Point2d firstPoint2D = randomPoints.GetRandomPoint(3, 10);
            Point2d secondPoint2D = randomPoints.GetRandomPoint(2, 3);
            Point3d firstPoint3D = randomPoints.GetRandomPoint(1, 1, 1);
            Point3d secondPoint3D = randomPoints.GetRandomPoint(10, 10, 10);

            double distanceBetween2DPoints = randomPoints.GetDistanceBetweenTwoPoints(firstPoint2D, secondPoint2D);
            double distanceBetween3DPoints = randomPoints.GetDistanceBetweenThreePoints3d(firstPoint3D, secondPoint3D);

            Console.WriteLine(firstPoint2D);
            Console.WriteLine(firstPoint3D);

            Console.WriteLine($"Distance between the 2 points is: {distanceBetween2DPoints}");
            Console.WriteLine($"Distance between all 3 points is: {distanceBetween3DPoints}");



            Console.ReadKey();
        }
    }
}
