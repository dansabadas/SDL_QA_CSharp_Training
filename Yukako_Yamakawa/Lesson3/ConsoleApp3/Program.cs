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

        public int Z { get; internal set; }

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
        //HOMEWORK 1
        double CalculateDistanceTo2D(Point2D firstPoint2D, Point2D secondPoint2D);
        double CalculateDistanceTo3D(Point3D firstPoint3D, Point3D secondPoint3D);
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

        //HOMEWORK 1 - function
        public double CalculateDistanceTo2D(Point2D firstPoint2D, Point2D secondPoint2D)
        {
            return Math.Sqrt(Math.Pow((secondPoint2D.X - firstPoint2D.X), 2) + Math.Pow((secondPoint2D.Y - firstPoint2D.Y), 2));
        }

        public double CalculateDistanceTo3D(Point3D firstPoint3D, Point3D secondPoint3D)
        {
            return Math.Sqrt(Math.Pow((secondPoint3D.X - firstPoint3D.X), 2) + Math.Pow((secondPoint3D.Y - firstPoint3D.Y), 2) + Math.Pow((secondPoint3D.Z - firstPoint3D.Z), 2));
        }
    }

    /* Homework 1: to the classes Point2D and Point3d that you created add for each class one new method double CalculateDistanceTo(Point2D/Point3D) 
     * which will calculate the physical distance between two points! It is just basic trigonometry!
     * Then on the main function please create 2 random 2D points and calculate the distance between them using a call like this: 
     * myFirstpoint2d.CalculateDistanceTo(mySecondPoint2d) and display that distance on Console.
     * Then do the same with 3D points!
     * HINT: in .Net there is a mathmatical function for calculating the square root (radacina patrata a unui numar) of a number:
     * Math.Sqrt(double number).
     */

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

            //HOMEWORK 1 - input + output
            var secondPoint2D = new Point2D(20, 30);
            var firstPoint2D = new Point2D(10, 15);

            var distanceBetweenTwo2DPoints = myFactoryOfPoint.CalculateDistanceTo2D(firstPoint2D, secondPoint2D);

            Console.WriteLine($"Distance between two 2D points : {distanceBetweenTwo2DPoints}");

            var secondPoint3D = new Point3D(20, 30, 50);
            var firstPoint3D = new Point3D(15, 40, 70);

            var distanceBetweenTwo3DPoints = myFactoryOfPoint.CalculateDistanceTo3D(firstPoint3D, secondPoint3D);

            Console.WriteLine($"Distance between two 3D points : {distanceBetweenTwo3DPoints}");



        }
    }

}