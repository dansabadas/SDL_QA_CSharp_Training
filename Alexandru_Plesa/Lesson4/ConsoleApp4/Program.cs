using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointFactory pointFactory = new PointFactory();
            ArrayList points = pointFactory.generatePoints(20);

            foreach (Point2D point2D in points)
            {
                Console.WriteLine(point2D);
            }

            Console.WriteLine("Overall Number Of Points: " + Point2D.OverallNumberOfPoints);
            Point2D point1 = new Point2D(1, 2);

            object point2 = point1;
            Console.WriteLine(point2);

            IPoint point3 = point1;
            Console.WriteLine(point3);

            Point2D point4 = (Point2D)point3;
            Console.WriteLine(point4);
 
            ArrayList r2 = new ArrayList();
            r2.Add(point1);
            r2.Add(point4);

            Console.WriteLine("Overall Number Of Points: " + Point2D.OverallNumberOfPoints);

            Animal pig = new Pig( 10 ,"Pig", 10);
            Console.WriteLine(pig);

            dynamic d1 = 2;
            dynamic d2 = "string";

            dynamic result1 = AddDynamic(d1, d2);
            dynamic result2 = AddDynamic(d2, d2);

            Console.WriteLine($"{result1}, {result2}");

            Engine engine = new Engine("Toyota", 99);
            Wheel w1 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w2 = new Wheel("Goodyear", WheelSize.Big);
            Wheel w3 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w4 = new Wheel("Mishlin", WheelSize.Big);
            Car myCar = new Car("BMW");

            myCar.Engine = engine;
            myCar.Wheels = new Wheel[4] { w1, w2, w3, w4 };

            Console.ReadLine();
        }

        public static dynamic AddDynamic(dynamic D1, dynamic D2)
        {
            return D1 + D2;
        }
    }
}
