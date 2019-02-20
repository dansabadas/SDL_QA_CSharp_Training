using System;
using System.Collections;

namespace ConsoleApp1
{
    public class Student
    {
        public int id;
        public string name;
        public DateTime dateOfBirth;
    }

    public class point2D
    {
        private double _x;
        private double _y;

        public double X {
            get { return _x; }
            set { if (value < 0) {
                    _x = -value;
                }
                else if (value > 0)
                { _x = value + 10; }
            }
        }
        public double Y => _y; 

        public point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public class point3D : point2D
        {
            private double _z; 
            public point3D(double x, double y, double z): base (x,y)

            {
                _z = z;
            }

        }


        public override string ToString()
        {
            return $"{_x},{_y}";
        }
    }

    public interface IGeometryFactory
    {
        ArrayList GetMyPoints();
        ArrayList GetRandomPoint(int maxX, int maxY);
        ArrayList GetRandomPoint3D(int x, int y, int z);
       }

    public interface IStudentRepository
    {
        ArrayList CreateAllStudents();
        ArrayList CreateAllStudents2();
    }

    public class Points : IGeometryFactory
    {
        public ArrayList GetMyPoints()
        {
            ArrayList myArrayList = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();

                point2D point = new point2D(random.NextDouble(), random.NextDouble());
                myArrayList.Add(point);
            }
            return myArrayList;
        }

        public ArrayList GetRandomPoint(int maxX, int maxY)
        {
            ArrayList myList2 = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();

                point2D point = new point2D(random.NextDouble() * maxX, random.NextDouble() * maxY);
                myList2.Add(point);
            }
            return myList2;
        }



        public ArrayList GetRandomPoint3D(int x, int y, int z)
        {
            point3D punct = new point3D(x, y, z);

   

        }



        public class StudentRepository
    {
        public string nameOfRepository = "some name"; 

        public ArrayList CreateAllStudents()
        {
            ArrayList myList = new ArrayList();
            for (int i = 1; i < 10; i++)
            {
                Student myStudent = new Student();
                myStudent.id = i;
                myStudent.name = "student name" + i;
                myStudent.dateOfBirth = DateTime.Today.AddYears(-i);
                myList.Add(myStudent);
                Console.WriteLine($"name { myStudent.name} data nasterii {myStudent.dateOfBirth}" );
            }
            return myList; 
        }

        public ArrayList CreateAllStudents2()
        {
            ArrayList myList = new ArrayList();
            for (int i = 1; i <= 10; i++)
            {
                
                Student myStudent = new Student();
                myStudent.id = i;
                myStudent.name = "student name" + i;
                myStudent.dateOfBirth = DateTime.Today.AddYears(-i);
                if (i%2 == 0)
                {
                    myList.Add(myStudent);
                    Console.WriteLine($"name { myStudent.name} data nasterii {myStudent.dateOfBirth}");
                }
            }
            return myList;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository myRepository= new StudentRepository(); 
            ArrayList myList = myRepository.CreateAllStudents2();
            Console.WriteLine("lesson3");

            Points PunctGeometric = new Points();
            ArrayList myListOfPoints = PunctGeometric.GetMyPoints();
            foreach (point2D punct in myListOfPoints)
            {
                Console.WriteLine($"{punct.X}, {punct.Y}");
            }

            ArrayList SecondList = PunctGeometric.GetRandomPoint(1, 2);
            foreach (point2D punct in SecondList)
            {
                Console.WriteLine($"{punct.X}, {punct.Y}");
            }

            point2D p2 = new point2D(2,3);
            p2.X = -30;
            Console.WriteLine(p2.ToString());
            p2.X = 100;
            Console.WriteLine(p2.ToString());

            Console.ReadKey();
                     
        }
    }
}
