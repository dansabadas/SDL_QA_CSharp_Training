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

    public interface IStudentRepostory  // I stands for interface
    {
        ArrayList CreateAllStudents();
        ArrayList CreateAllStudents2();
    }

    public class StudentRepository : IStudentRepostory

    {
        public string NameOfRepository = "some name";

        public ArrayList CreateAllStudents()


         {
            ArrayList myList = new ArrayList();
            int iterator = 0;   // starting point
            while (iterator < 100)  //ending point = integer 99
            {
                Student myStudent = new Student();
                myStudent.Id = iterator;
                myStudent.Name = "Student Name " + iterator;
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
            int iterator = 0;   // starting point
            while (iterator < 100)  //ending point = integer 99
            {

                Student myStudent = new Student();
                myStudent.Id = iterator;
                myStudent.Name = "Student Name " + iterator;
                myStudent.DateOfBirth = DateTime.Today.AddYears(-iterator);
                if (iterator % 2 == 0)  //alternatively, change to "iterator ++2;" to increment the incrementor by 2 instead
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
            return $"[{this._x},{_y}, {_z}]"; 
        }
    }

    public class Point2D
    {
        protected double _x;  //when "public" is changed to "private", the values XY become read only
        public double X   // it is mapped to private _x   & This is a property
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


        protected double _y;
        public double Y => _y;

        public Point2D(double x, double y)
        {
            _x = x;  //??? ask Ovidiu why these expressions are needed
            _y = y;
        }

        public override string ToString()   //inheriting the method of the object of "ToString"
        {
            return $"({this._x},{_y})"; //does not matter if "this." is added or not
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
                Point2D aPoint = new Point2D(x: random.NextDouble() * 10, y: random.NextDouble() * 10);


                myArrayList.Add(aPoint);
            }

            return myArrayList;
        }

        public Point2D GetRandomPoint(int maxX, int maxY)
        {
            Random random = new Random();
            Point2D aPoint = new Point2D(x: random.NextDouble() * maxX, y: random.NextDouble() * maxY);

            return aPoint;
        }

        public Point3D GetRandomPoint(int maxX, int maxY, int maxZ)

        {
            Random random = new Random();
            Point3D aPoint = new Point3D(x: random.NextDouble() * maxX, y: random.NextDouble() * maxY, z: random.NextDouble() * maxZ);

            return aPoint;

            //throw new NotImplementedException();

        }

    }

        class Program
    {
        static void Main(string[] args)
        {
            IStudentRepostory myRepository = new StudentRepository();
            
            ArrayList myList = myRepository.CreateAllStudents2();
            
            //for statement - print for each student their name and date of birth
            foreach (Student student in myList)
            {
                Console.WriteLine(value: student.Name + " " + student.DateOfBirth);
                Console.WriteLine(student.ToString());
            }

            IGeometryFactory myFactoryOfPoint = new GeometryFactory();
            ArrayList pointList = myFactoryOfPoint.GetMyPoints();
            foreach (Point2D point in pointList)
            {
                //Console.WriteLine(value:$"({point.X},{point.Y})");
                Console.WriteLine(point.ToString());
            }

            var myPoint1 = myFactoryOfPoint.GetRandomPoint(maxX: 2, maxY: 3);
            //myPoint1.Y = 100000;
            //Console.WriteLine(value: $"({myPoint1.X},{myPoint1.Y})");
            Console.WriteLine(myPoint1.ToString());
            Console.WriteLine(myPoint1.X + " ", myPoint1.Y);
            Console.WriteLine(value: "Hello Yukako - this is lesson 3");

            Point2D p2 = new Point2D(x: 10, y: 20);
            p2.X = -30;
            Console.WriteLine(p2.ToString());
            p2.X = 100;
            Console.WriteLine(p2.ToString());

            var myPoint3 = myFactoryOfPoint.GetRandomPoint(maxX: 200, maxY: 300, maxZ: 400);
            Console.WriteLine(myPoint3.ToString());
            Console.WriteLine(myPoint3);
        }
    }

}