using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointsFactory myFactory = new PointsFactory();
            ArrayList myArrayList = myFactory.GeneratePoints(20);

            foreach (Point2D o in myArrayList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Overall points created up until now: " + Point2D.OverallNumberOfPoints);

            Point2D p1 = new Point2D(2, 3);
            //OverallNumberOfPoints[p1x,y]...[p2x,y][p3x,y][][]
            object p2 = p1;
            int i1 = -4;
            object i2 = i1;

            Console.WriteLine(p2);
            IPoint p3 = p1;
            Point2D p4 = (Point2D)p3;
            Console.WriteLine(p3.X);
            Console.WriteLine(p4);

            ArrayList arr2 = new ArrayList();
            arr2.Add(p1);
            arr2.Add(p4);

            Animal a1 = new Pig();
            a1.Id = 1;
            a1.Name = "Babe ";
            Console.WriteLine(a1);

            dynamic d1 = 2;
            dynamic d2 = "my string";

            dynamic result1 = AddDynamic(d1, d1);
            dynamic result2 = AddDynamic(d2, d2);
            Console.WriteLine($"{result1} {result2}");


            Engine engine1 = new Engine("Toyota", 135);
            Wheel w1 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w2 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w3 = new Wheel("Goodyear", WheelSize.Big);
            Wheel w4 = new Wheel("Michelin", WheelSize.Big);

            Car car1 = new Car("BMW");
            car1.Engine = engine1;
            car1.Wheels = new Wheel[4] { w1, w2, w3, w4 };
        }

        public static dynamic AddDynamic (dynamic d1, dynamic d2)
        {
            return d1 + d2;
        }
    }
}
