using System;
using System.Collections;

namespace ConsoleApp1
{
    public class Student
    {
        public string name;
        public int id;
        public DateTime dateOfBirth;

    }

    public interface IStudentRepo
    {
        ArrayList CreateAllStudents();
        ArrayList CreateAllStudents2();
    }

    public class Student_Repository : IStudentRepo
    {
        
        public ArrayList CreateAllStudents()
        {
            ArrayList mylist = new ArrayList();
            int count = 0;

            while (count < 100)
            {
                Student myStudent = new Student();
                myStudent.id = count;
                myStudent.name = "student name" + count;
                myStudent.dateOfBirth = DateTime.Today.AddYears(-count);
                mylist.Add(myStudent);
                count++;
            }


            return mylist;
        }

        public ArrayList CreateAllStudents2()
        {
            ArrayList mylist = new ArrayList();
            int count = 0;

            while (count < 100)
            {
                Student myStudent = new Student();
                myStudent.id = count;
                myStudent.name = "student name" + count;
                myStudent.dateOfBirth = DateTime.Today.AddYears(-count);
                if (count % 2 == 0)
                {
                    mylist.Add(myStudent);
                }

                
                count++;
            }


            return mylist;
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
            _x=x;
            _y=y;
        }
        public override string ToString()
        {
            return $"(x:{_x},y:{_y})";
        }
    }

    public interface IGeometricalFactory
    {
        ArrayList GetPoints();
        Point2D GetMaxPoint(int maxx, int maxy);
        Point3D Getrandom();
    }

    public class ImplementationPoints : IGeometricalFactory
    {
        Random random = new Random();

        public  Point3D Getrandom()
        {
            Point3D point1 = new Point3D(random.NextDouble(), random.NextDouble(), random.NextDouble());
            return point1;

        }

        public ArrayList GetPoints()
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                
                Point2D point = new Point2D(x:random.NextDouble(), y:random.NextDouble());
                list.Add(point);
            }
            return list;
        }

        public Point2D GetMaxPoint(int maxx, int maxy)
        {
            Point2D point = new Point2D();
            point.X = random.NextDouble()*maxx;
            point.Y = random.NextDouble() * maxy;

            return point;
        }

        
    }


    public class Point3D : Point2D
    {
        private double _z;
        public Point3D(double x,double y, double z) :base (x, y)
        {
            _z = z;
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {

            Student_Repository studentRepo = new Student_Repository();
           // studentRepo.CreateAllStudents();
            ArrayList mylist = studentRepo.CreateAllStudents2();

            foreach (Student student in mylist)
            {
                Console.WriteLine(student.name +" "+ student.dateOfBirth);
            }


            IGeometricalFactory geometryFactory = new ImplementationPoints();
            var points = geometryFactory.GetPoints();
            foreach (Point2D point in points)
            {
                Console.WriteLine($"X={point.X} Y={point.Y}");
            }

           
            Console.ReadKey();

             
        }
    }
}
