using System;
using System.Collections;

namespace ConsoleApp3
{
    public class Student
    {
        public int id;
        public string name;
        public DateTime dateOfBirth;

        public override string ToString()
        {
            return $"(X),(this Y)";
        }

        public interface IStudentRepository
        {
            ArrayList CreateAllStudents();
            ArrayList CreateAllStudents2();
        }
               
        public class StudentRepository
        {
            public ArrayList CreateAllStudents()
            {

                ArrayList myList = new ArrayList();
                int iterator = 0;
                while (iterator < 100)
                {
                    Student mystudent = new Student();
                    mystudent.id = iterator;
                    mystudent.name = "student name " + iterator;
                    mystudent.dateOfBirth = DateTime.Today.AddYears(-iterator);
                    myList.Add(mystudent);
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
                    Student mystudent = new Student();
                    mystudent.id = iterator;
                    mystudent.name = "student name " + iterator;
                    mystudent.dateOfBirth = DateTime.Today.AddYears(-iterator);

                    if (iterator % 2 == 0)
                    {
                        myList.Add(mystudent);
                    }

                    iterator++;
                }

                return myList;
            }
        }

        public class Point3D : Point2D
        {
            private double _z;

            public Point3D (double x, double y, double z) : base (x, y)
            {
                _z = z;
            }
        }
        
        public class  Point2D
        {
            public double X;
            public double Y;

            public Point2D(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        public interface IGeometryFactory
        {
            ArrayList GetPoints();
        }

        public class GeometryFactory : IGeometryFactory
        {
            public ArrayList GetPoints()
            {
                ArrayList myArrayList = new ArrayList();
                for (int i = 0; i < 20; i++)
                {
                    Random random = new Random(i);
                    Point2D coord = new Point2D(random.NextDouble() * 10, random.NextDouble() * 10);
                    myArrayList.Add(coord);
                }
                return myArrayList;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World");

                //IStudentRepository myRepository = new IStudentRepository();
                StudentRepository myRepository = new StudentRepository();

                ArrayList myList = myRepository.CreateAllStudents2();

                foreach (Student student in myList)
                {
                    Console.WriteLine(student.name + " " + student.dateOfBirth);
                }

                IGeometryFactory myFactoryOfPoin = new GeometryFactory();
                ArrayList pointList = myFactoryOfPoin.GetPoints();


                foreach (Point2D student in pointList)
                {
                    Console.WriteLine($"point.X + point.Y");
                }

            }
        }
    }
}
