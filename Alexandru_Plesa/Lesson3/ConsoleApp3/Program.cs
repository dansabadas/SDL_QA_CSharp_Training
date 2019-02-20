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
        public string Name;
        public int ID;
        public DateTime DateOfBirth;
    }

    public class StudentRepository : iStudentRepository
    {
        string nameOfRepository;

        public ArrayList CreateAllStudents(int nr)
        {
            ArrayList students = new ArrayList();

            for (int i = 0; i < nr; i++)
            {
                Student student = new Student();

                student.ID = i;
                student.Name = "Some Name " + i;
                student.DateOfBirth = DateTime.Now.AddYears(-i);

                students.Add(student);
            }
            
            return students;
        }

        public ArrayList CreateAllStudents2(int nr)
        {
            ArrayList students = new ArrayList();

            for (int i = 0; i < nr; i++)
            {
                if (i % 2 == 0)
                {
                    Student student = new Student();

                    student.ID = i;
                    student.Name = "Some Name " + i;
                    student.DateOfBirth = DateTime.Now.AddYears(-i);

                    students.Add(student);
                }
                
            }

            return students;
        }

    }

    public interface iStudentRepository
    {
        ArrayList CreateAllStudents(int nr);
        ArrayList CreateAllStudents2(int nr);
    }


    public class Point2D
    {
        protected double _x;
        protected double _y;

        public double X
        {
            get => _x;
            set => _x = value;
        }
        public double Y
        {
            get => _y;
            set
            {
                if (value < 0)
                {
                    _y = value * -1;
                } else
                {
                    _y = value;
                }
                
            }
        }

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"(X:{_x}, Y:{_y})";
        }


    }
    public class Point3D : Point2D
    {
        protected double _z;

        public double Z
        {
            get => _z;
            set => _z = value;
        }

        public Point3D(double x, double y, double z) : base(x, y)
        {
            _z = z;
        }

        public override string ToString()
        {
            return $"(X:{_x}, Y:{_y} Z:{_z})";
        }
    }

    public interface iGeometryFactory
    {
        ArrayList GetMyPoints(int points);
        Point2D GetRandomPoint(int maxX, int maxY);
        Point3D GetRandomPoint(int maxX, int maxY, int maxZ);

    }

    public class GeometryFactory : iGeometryFactory
    {
        Random rnd = new Random();

        public ArrayList GetMyPoints(int points)
        {
            
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < points; i++)
            {
                Point2D point2D = new Point2D(rnd.Next(0, points), rnd.Next(0, points));

                arrayList.Add(point2D);

            }
            return arrayList;
        }

        public Point2D GetRandomPoint(int maxX, int maxY)
        {
            Point2D point = new Point2D(rnd.NextDouble() * maxX, rnd.NextDouble() * maxY);

            return point;

        }

        public Point3D GetRandomPoint(int maxX, int maxY, int maxZ)
        {
            Point3D point = new Point3D(rnd.NextDouble() * maxX, rnd.NextDouble() * maxY, rnd.NextDouble() * maxZ);

            return point;
        }
    }



    class Program
    {
    
        static void Main(string[] args)
        {
            Student student = new Student();
            iStudentRepository studentRepository = new StudentRepository();

            ArrayList students = studentRepository.CreateAllStudents(10);

            foreach(Student stud in students)
            {
                Console.WriteLine($"Student {stud.Name} has the ID {stud.ID} and was born {stud.DateOfBirth}");
            }

            ArrayList students2 = studentRepository.CreateAllStudents2(10);

            foreach (Student stud in students2)
            {
                Console.WriteLine($"Student {stud.Name} has the ID {stud.ID} and was born {stud.DateOfBirth}");
            }

            iGeometryFactory randomPoints = new GeometryFactory();
            ArrayList points = randomPoints.GetMyPoints(20);
            
            foreach (Point2D pnt in points)
            {  
                Console.WriteLine(pnt.ToString());
            }

            Point2D point2D = randomPoints.GetRandomPoint(10, 10);
            Point3D point3D = randomPoints.GetRandomPoint(10, 10, 10);
            
            Console.WriteLine(point2D.ToString());
            Console.WriteLine(point3D);

            Console.ReadLine();
            
            
        }
    }
}
