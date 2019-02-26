using System.Collections;
using ClassLibrary1;
using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPoinsFactory myFactory = new PointsFactory();
            ArrayList myArrayList = myFactory.GeneratePoints(20);

            foreach (Point2D p in myArrayList)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine(value: "Overall number of points generated up to now: " + Point2D.OverallNumberOfPoints);
            Point2D p1 = new Point2D(x:2, y:3);
            //OverallNumberOfPoints[p1x,y]...[p3x,y][][]

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

            Console.WriteLine(value: "Overall number of points generated up to now: " + Point2D.OverallNumberOfPoints);

            Animal a1 = new Pig();  //NOTE: if you put "Animal", since it is abstruct, it would complain unlessyou add the interface
            a1.Id = 1;
            a1.Name = "Babe";
            Console.WriteLine(a1);

            dynamic d1 = 2;
            dynamic d2 = "my string";

            dynamic result1 = AddDynamic(d1, d1);
            dynamic result2 = AddDynamic(d2, d2);
            Console.WriteLine(value: $"{result1} {result2}");
            //QUESTION: when result1.Blabla = "Blabla" is still complained here although in theory, dynamic value should now be flexible

            Engine engine1 = new Engine(name: "Toyota", power: 135);
            Wheel w1 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w2 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w3 = new Wheel("Goodyear", WheelSize.Big);
            Wheel w4 = new Wheel("Michellan", WheelSize.Big);

            Car car1 = new Car(name: "BMW");
            car1.Engine = engine1;
            car1.Wheels = new Wheel[4] {w1, w2, w3, w4};
        }

        public static dynamic AddDynamic(dynamic d1, dynamic d2)
        {
            return d1 + d2;
        }

    }
}
