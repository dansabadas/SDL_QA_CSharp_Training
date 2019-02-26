using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointsFactory myFactory = new PointsFactory();
            ArrayList myArray = myFactory.Generate(20);

            foreach(Point2D o in myArray)
            {
                Console.WriteLine(o);
            }
            

            Point2D p1 = new Point2D(4,6);
            object p2 = p1;
            Console.WriteLine(p2);

            IPoint p3 = p1;
            Point2D p4 = (Point2D)p3;
            Console.WriteLine(p3.X);

            ArrayList array2 = new ArrayList();
            array2.Add(p1);
            array2.Add(p4);
            Console.WriteLine(Point2D.overAllNoOfPoints);

            Animal a1 = new Pig();
            a1.id = 1;
            a1.name = "porcu";

            Console.WriteLine(a1);
            dynamic d1 = 2;
            dynamic d2 = "ewr3wrfw";
            dynamic d3 = AddDynamic(d1, d1);
            Console.WriteLine(d3);

            Engine engine = new Engine("bmw", 234);
            Wheel w1 = new Wheel("dunlop", WheelSize.large);
            Wheel w2 = new Wheel("dunlop", WheelSize.large);
            Wheel w3 = new Wheel("dunlop", WheelSize.large);
            Wheel w4 = new Wheel("dunlop", WheelSize.large);

            Car car1 = new Car("bmw");
            car1.Engine = engine;
            car1.Wheels = new Wheel[4] { w1, w2, w3, w4 };
            Console.ReadKey();
        }

        public static dynamic AddDynamic(dynamic d1, dynamic d2)
        {
            return d1 + d2;
        }
    }
}
