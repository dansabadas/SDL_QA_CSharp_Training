using ClassLibrary1;
using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointsFactory myFactory = new PointsFactory();
            ArrayList myArrayList = myFactory.GeneratePoints(20);

            foreach (Point2D p in myArrayList)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("Overall numer of points created: " + Point2D.OverallNumberOfPoints);

            Point2D p1 = new Point2D(2, 3);

            object p2 = p1;
            Console.WriteLine(p2);

            int i1 = -4;
            object i2 = i1;

            IPoint p3 = p1;

            Point2D p4 = (Point2D)p3;
            Console.WriteLine(p3.X);
            Console.WriteLine(p4);

            ArrayList arr2 = new ArrayList();
            arr2.Add(p1);
            arr2.Add(p4);

            Console.WriteLine("Overall numer of points created: " + Point2D.OverallNumberOfPoints);

            Animal a1 = new Pig();
            a1.ID = 1;
            a1.Name = "Babe";
            Console.WriteLine(a1);

            dynamic d1 = 2;
            dynamic d2 = "my String";

            dynamic result1 = AddDynamic(d1, d1);
            dynamic result2 = AddDynamic(d2, d2);
            Console.WriteLine($"{result1} {result2}");

            Engine engine1 = new Engine("Toyota", 135);
            Wheel wheel1 = new Wheel("Dunlop", WheelSize.Big);
            Wheel wheel2 = new Wheel("Dunlop", WheelSize.Big);
            Wheel wheel3 = new Wheel("Goodyear", WheelSize.Big);
            Wheel wheel4 = new Wheel("Michelin", WheelSize.Big);

            Car car1 = new Car("BMW");
            car1.Engine = engine1;
            car1.Wheels = new Wheel[4] { wheel1, wheel2, wheel3, wheel4 };

            IBank Bank = new Bank();
            ArrayList transactions = Bank.GenerateFinancialTransactions(20);
            foreach (FinancialTransaction transaction in transactions)
            {
                Console.WriteLine(transaction.ToString());
            }

            Console.Read();
        }

        public static dynamic AddDynamic(dynamic d1, dynamic d2)
        {
            return d1 + d2;
        }
    }
}
