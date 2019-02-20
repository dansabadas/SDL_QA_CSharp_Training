using System;
using System.Collections;

//return an array list with 100 users
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
        public ArrayList CreateAllStudents()
        {
            ArrayList myList = new ArrayList();
            int iterator = 0;
            while (iterator < 100)
            {
                Student myStudent = new Student();
                myStudent.Id = iterator;
                myStudent.Name = "student name" + iterator;
                myStudent.DateOfBirth = DateTime.Today.AddYears(-iterator);
                myList.Add(myStudent);
                iterator++;
            }
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
                myStudent.Name = "student name" + iterator;
                myStudent.DateOfBirth = DateTime.Today.AddYears(-iterator);
                if (iterator % 2 == 0)
                {
                    myList.Add(myStudent);
                }
                iterator++;
            }
            return myList;
        }
    }



    //public ArrayList CreateAllStudents2() //trebuia sa afiseze students par, vezi acasa
    //{
    //    ArrayList myList = new ArrayList();
    //    int iterator = 0;
    //    while (iterator < 100)
    //    {
    //        Student myStudent = new Student();
    //        myStudent.Id = iterator;
    //        myStudent.Name = "student name" + iterator;
    //        myStudent.DateOfBirth = DateTime.Today.AddYears(-iterator);
    //        if (iterator % 2 == 0)
    //        {
    //            myList.Add(myStudent);
    //        }
    //        iterator++;
    //    }
    //    return myList;
    //}
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
        }



    }
    public class Point2D
    {
     private double _x;

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

    private double _y;
        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                if (value < 0)
                    _x = -value;
                else
                _y = _y + 10; 
            }
        }

    
    public Point2D(double x, double y)
    {
            _x = x;
            _y = y;

    }

        public override string ToString()
        {
            return $"({X}, {Y})";

        }
    }

    public interface IGeometryFactory
    {
        ArrayList GetMyPoints();
        Point2D getMaximumPoint (int maxX, int maxY);
        Point3D getMaximumPoint(int maxX, int maxY, int maxZ);
    }

   

    public class GeometryFactory : IGeometryFactory
    {
        ArrayList points = new ArrayList();
        public Point2D getMaximumPoint(int maxX, int maxY)
        {
            Random random = new Random();
            Point2D aPoint = new Point2D(random.Next(maxX,10), random.Next(maxY, 10));
            return aPoint;
        }

        public Point3D getMaximumPoint(int maxX, int maxY, int maxZ)
        {

            Random random = new Random();
            Point3D aPoint = new Point3D(random.Next(0, 10), random.Next(2, 5), random.Next(6, 9));
            return aPoint;
        }

        public ArrayList GetMyPoints()
        {
            for (int i =0; i<20; i++)
            {
                Random random = new Random(i);
                Point2D aPoint = new Point2D(random.NextDouble() * 10, random.NextDouble() * 10);
                points.Add(aPoint);
            }

            return points;
        }

        public Point3D GetRandomPoint (int maxX, int maxY, int maxZ)
        {
            Random random = new Random();
            Point3D aPoint = new Point3D(random.Next(0, 10), random.Next(2, 5), random.Next(6, 9));
                return aPoint;
        }
    }


    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello lesson 3!");
                StudentRepository myRepository = new StudentRepository();
                ArrayList myList = myRepository.CreateAllStudents();
                foreach (Student student in myList)
                {
                    Console.WriteLine(student.Name + " " + student.DateOfBirth);
                }

            IGeometryFactory geometryfactory = new GeometryFactory();
            ArrayList pointsList = new ArrayList();
            pointsList = geometryfactory.GetMyPoints();
                foreach (Point2D point in pointsList)
            {
                Console.WriteLine($"{point.X},{point.Y}");
            }
            Point3D piont3d = new Point3D(3,4,5);
            Console.WriteLine($"{piont3d.X}, {piont3d.Y}, {piont3d.Z}");



                 
            //Point2D point2 = geometryfactory.getMaximumPoint(1, 2);
            //Console.WriteLine($"{point2.X}, {point2.Y}");
            //Console.WriteLine(point2.ToString());
            


            //IStudentRepository myRepository = new IStudentRepository();
            //ArrayList myList = myRepository.CreateAllStudents2();
            }
        }
    }


