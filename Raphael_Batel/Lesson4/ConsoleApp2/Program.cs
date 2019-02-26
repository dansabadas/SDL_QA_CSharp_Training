using ClassLibrary1;
using Lesson4_ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointsFactory pointsFactory = new PointsFactory();
            ArrayList points = pointsFactory.GeneratePoints(20);
            foreach (Point2D p in points)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Overall number of points created: " + Point2D.OverallNumberOfPointsCreated);

            Point2D p1 = new Point2D(2, 3);
            object p2 = p1;
            Console.WriteLine(p2);

            int i1 = -4;
            object i2 = i1;

            IPoint p3 = p1;

            Point2D p4 = (Point2D) p3;
            Console.WriteLine(p3.X);
            Console.WriteLine(p4);

            ArrayList arr2 = new ArrayList();
            arr2.Add(p1);
            arr2.Add(p4);

            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine("Overall number of points created: " + Point2D.OverallNumberOfPointsCreated);

            Animal a1 = new Pig { Id = 1, Name = "Babe" } ;
            Console.WriteLine(a1);

            dynamic d1 = 2;
            dynamic d2 = "my string";
            dynamic result1 = AddDynamic(d1, d1);
            dynamic result2 = AddDynamic(d2, d2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);


            Engine engine1 = new Engine("Toy Yoda", 135);
            Wheel w1 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w2 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w3 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w4 = new Wheel("Dunlop", WheelSize.Big);

            Car car1 = new Car("BMW");
            car1.Engine = engine1;
            car1.Wheels = new Wheel[] { w1, w2, w3, w4 };

        }

        public static dynamic AddDynamic(dynamic d1, dynamic d2)
        {
            return d1 + d2;
        }
    }
}
