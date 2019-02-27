using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPointsFactory myFactory = new PointsFactory();
            ArrayList myList = new ArrayList();
            myList= myFactory.GeneratePoints(20);
            foreach(Point2D point in myList)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("Overall nr of points= " + Point2D.OverallNumberOfPoints);
        
            Point2D p1 = new Point2D(2,3);
           
            //OverallNumberOfPoints[p1x,y]...[p3x,y][][]
            // OverallNumberOfPoints stays at the same location in memory while the other variables(instance) change their location 
            // static variables are not garbage collected

            object p2 = p1;  // compiler creates a copy of p1 and adds it to p2
            int i1 = -4;
            object i2 = i1; // structs are allocated into stack, objects into heap. heap is slower than the stack
            Console.WriteLine(p2);

            IPoint p3 = p1; // p3 exists on the heap because is an interface

            Point2D p4 = (Point2D)p3;  //boxing = take a variable from the stack and copy it to heap; reverse = unboxing
            Console.WriteLine(p3.X);
            Console.WriteLine(p4);

            ArrayList arr2 = new ArrayList();
            arr2.Add(p1); // automatical boxing  -  Point2D is  converted to object
            arr2.Add(p4);
            Console.WriteLine("Overall nr of points= " + Point2D.OverallNumberOfPoints);

            //  Animals A1 = new Animals(); abstract classes cannot be instanciated
            Animals a1 = new Pig();
            a1.Id =1;
            a1.Name = "Babe";
            Console.WriteLine(a1);

            dynamic d1 = 2;
            dynamic d2 = "my string"; // gives the look and feel of javascript
            dynamic result1 = AddDynamic(d1, d1);
            dynamic result2 = AddDynamic(d2, d2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            //result1.blabla();  you can invoke any method, but it will fail only at runtime

            Engine engine1 = new Engine("Toyota", 135);
            Wheel w1 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w2 = new Wheel("Dunlop", WheelSize.Big);
            Wheel w3 = new Wheel("Goodyear", WheelSize.Big);
            Wheel w4 = new Wheel("Michelin", WheelSize.Big);

            Car car1 = new Car("BMW");
            car1.Engine = engine1;
            car1.Wheels = new Wheel[4] { w1, w2, w3, w4 };

            Console.WriteLine();
            //Homework Lesson 4

            IBank myBank = new Bank();
            ArrayList transactions = new ArrayList();
            transactions = myBank.GenerateFinancialTransactions();
            foreach (FinancialTransaction transaction in transactions)
            {              
                Console.WriteLine($"({transaction.From.Name}, {transaction.To.Name}, {transaction.Amount})");
            }
        }
        public static dynamic AddDynamic(dynamic d1, dynamic d2)
        {
            return d1 + d2;
        }

    }
}
