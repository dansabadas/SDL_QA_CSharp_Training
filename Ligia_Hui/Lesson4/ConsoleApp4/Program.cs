using System;
using ClassLibrary1;
using System.Collections;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointsFactory myFactory = new PointsFactory();
            ArrayList myArray = myFactory.Generate(20);

            foreach (Point2d o in myArray)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Overall number of points created up untill now:" + Point2d.OveralNumberOfPoints);
            Point2d p1 = new Point2d(4, 6);
            // OveralNumberOfPoints [p1x,y] [p2x,y] [p3x,y] [] []
            object p2 = p1;

            int i1 = -4;
            object i2 = i1;

            Console.WriteLine(p2);
            

            Ipoint p3 = p1;

            Point2d p4 =(Point2d) p3;
            Console.WriteLine(p3.X);
            Console.WriteLine(p4);

            ArrayList arr2 = new ArrayList();
            arr2.Add(p1);
            arr2.Add(p4);
            Console.WriteLine("Overall number of points created up untill now:" + Point2d.OveralNumberOfPoints);

            Animal a1 = new Pig();
            a1.Id = 1;
            a1.Name = "Vlad";
            Console.WriteLine(a1);

            dynamic d1 = 2;
            dynamic d2 = "my string";

            dynamic resoult1 = AddDynamic(d1,d1);
            dynamic resoult2 = AddDynamic(d2, d2);
            Console.WriteLine($"{resoult1} {resoult2}");

            Engine engine1 = new Engine("Toyota", 135);
            wheel w1 = new wheel("Dunlop", WhellSize.Big);
            wheel w2 = new wheel("Dunlop", WhellSize.Big);
            wheel w3 = new wheel("Dunlop", WhellSize.Big);
            wheel w4 = new wheel("Dunlop", WhellSize.Big);

            car car1 = new car("BMW");
            car1.Engine = engine1;
            car1.wheels= new wheel[4] { w1, w2, w3, w4 };
            Console.ReadKey();
        }

        public static dynamic AddDynamic (dynamic d1,dynamic d2)
        {
            return d1 + d2;
        }
    }
}