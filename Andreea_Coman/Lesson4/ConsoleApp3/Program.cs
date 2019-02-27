using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointsFactory myFactory = new PointsFactory();
            ArrayList myArrayList = myFactory.GeneratePoints(20);
            foreach (Point2D p in myArrayList)
            {
                Console.WriteLine(p);
            }
          
            Point2D p1 = new Point2D(3, 5);
            
            object p2 = p1;
            Console.WriteLine(p2);

            IPoint p3 = p1;

            Point2D p4 = (Point2D)p3;
            Console.WriteLine(p3.X);
            Console.WriteLine(p4);

            ArrayList arr2 = new ArrayList();  
            // boxing; copying from stack to heap 
            arr2.Add(p1);
            arr2.Add(p4);

            Console.WriteLine("overall number of points created so far" + Point2D.OverallNumberOfPoints);

            Animal A1 = new Pig();
            A1.id = 1;
            A1.name = "Babe";
            Console.WriteLine(A1);

            dynamic d1 = 2;
            dynamic d2 = "my string";

            dynamic Result1 = AddDynamic(d1, d1);
            dynamic Result2 = AddDynamic(d2, d2);
            Console.WriteLine($"{Result1} {Result2}");

            Engine engine1 = new Engine("Toyota", 134);
            Wheel w1 = new Wheel("Dunlop", Wheel.WheelSize.small);
            Wheel w2 = new Wheel("Pirelli", Wheel.WheelSize.small);
            Wheel w3 = new Wheel("Dunlop", Wheel.WheelSize.small);
            Wheel w4 = new Wheel("Pirelli", Wheel.WheelSize.small);

            //....

            Car car1 = new Car("BMW");
            car1.Engine = engine1;
            car1.Wheels = new Wheel[4] { w1, w2, w3, w4 };
            Console.ReadKey(); 

        }

        public static dynamic AddDynamic(dynamic d1, dynamic d2)
        {
            return d1 + d2; 
        }
    }
}
