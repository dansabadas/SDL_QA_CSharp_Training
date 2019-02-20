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
        private double _z;
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
            set
            {
                if ( value < 0)
                {
                    _x = -value;
                }
                else
                {
                    _x =  value + 10;
                }
            }
        }

        public double y
        {
            get { return _y; }
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
    }


    class Program
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

            Console.Read();
        }
    }
}
