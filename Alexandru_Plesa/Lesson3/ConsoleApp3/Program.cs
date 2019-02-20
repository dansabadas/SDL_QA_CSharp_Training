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


    public class point2D
    {
        protected double _x;
        protected double _y;

        public double X
        {
            get { return _x; }
            set => _x = value;
        }

          


        public double Y
        {
            get { return _y; }
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

        public point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"(X:{_x}, Y:{_y})";
        }


    }
    public class Point3D : point2D, iGeometryFactory
    {
        protected double _z;
        public Point3D(double x, double y, double z) : base(x, y)
        {
            double _x = x;
            double _y = y;
            double _z = z;
        }

        public ArrayList GetMyPoints(int points)
        {
            throw new NotImplementedException();
        }

        public point2D GetRandomPoint(int maxX, int maxY)
        {
            throw new NotImplementedException();
        }

        public Point3D GetRandomPoint(int maxX, int maxY, int maxZ)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"(X:{_x}, Y:{_y} Z:{_z})";
        }
    }

    public interface iGeometryFactory
    {
        ArrayList GetMyPoints(int points);
        point2D GetRandomPoint(int maxX, int maxY);

        Point3D GetRandomPoint(int maxX, int maxY, int maxZ);

    }

    public class ImplementGeometryFactory : iGeometryFactory
    {
        Random rnd = new Random();
        public ArrayList GetMyPoints(int points)
        {
            
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < points; i++)
            {
                point2D point2D = new point2D(rnd.Next(0, points), rnd.Next(0, points));

                arrayList.Add(point2D);

            }
            return arrayList;
        }

        public point2D GetRandomPoint(int maxX, int maxY)
        {
            point2D point = new point2D(rnd.NextDouble() * maxX, rnd.NextDouble() * maxY);

            return point;

        }

        public Point3D GetRandomPoint(int maxX, int maxY, int maxZ)
        {
            throw new NotImplementedException();
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

            iGeometryFactory randomPoints = new ImplementGeometryFactory();
            ArrayList points = randomPoints.GetMyPoints(20);
            
            foreach (point2D pnt in points)
            {  
                Console.WriteLine(pnt.ToString());
            }

            point2D point = randomPoints.GetRandomPoint(10, 10);
            Console.WriteLine(point.ToString());

            Point3D point3D = randomPoints.GetRandomPoint

            Console.ReadLine();
            
            
        }
    }
}
