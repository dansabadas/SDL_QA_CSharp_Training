using System;
using System.Collections;

namespace Homework_ex1

{
    public class point2D
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
        }
        public double Y => _y;

        public point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double DistanceTO(double a, double b)
        {
            double distance = Math.Sqrt((a - _x) * (a - _x) + (b - _y) * (b - _y));
            return distance;
        }
    }
      
    public interface IGeometryFactory
    {
        ArrayList GetMyPoints();
        ArrayList GetRandomPoint(int maxX, int maxY);
      //  ArrayList GetRandomPoint3D(int x, int y, int z);
    }

    public class Points : IGeometryFactory
    {
        public ArrayList GetMyPoints()
        {
            // generez o lista de numere random cu 2 dimensiuni 
            ArrayList myArrayList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                point2D point = new point2D(random.NextDouble(), random.NextDouble());
                myArrayList.Add(point); // imi afiseaza de 5 ori aceleasi numere 
            }
            return myArrayList;
        }

        public ArrayList GetRandomPoint(int maxX, int maxY)
        {
            ArrayList myList2 = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                point2D point = new point2D(random.NextDouble() * maxX, random.NextDouble() * maxY); // transform numerele obtinute anterior 
                myList2.Add(point);
            }
            return myList2;
        }

        class Program
        {
            static void Main(string[] args)
            {
                //Points PunctGeometric = new Points();

                //ArrayList myListOfPoints = PunctGeometric.GetMyPoints();
                //foreach (point2D punct in myListOfPoints)
                //{
                //    Console.WriteLine($"{punct.X}, {punct.Y}"); // afisez prima lista, cea din GetMyPoints
                //}

                //ArrayList SecondList = PunctGeometric.GetRandomPoint(120, 5);
                //foreach (point2D punct in SecondList)
                //{
                //    Console.WriteLine($"{punct.X}, {punct.Y}");  // afisez a doua lista, cea cu numerele diferite, din GetRandomPoint
                //}

                Console.WriteLine("Calculam distanta dintre doua numere 2D");
                Console.WriteLine("cream primul punct ");                           
                point2D myFisrtPoint2D = new point2D(12, -14);
                Console.WriteLine($"{ myFisrtPoint2D.X},{ myFisrtPoint2D.Y}");
                
                Console.WriteLine("cream al doilea punct");
                point2D mySecondPoint2D = new point2D(4, 8);
                Console.WriteLine($"{mySecondPoint2D.X}, {mySecondPoint2D.Y}");

                Console.WriteLine("afisam distanta");
                Console.WriteLine($"{myFisrtPoint2D.DistanceTO(mySecondPoint2D.X, mySecondPoint2D.Y)}");
                             
                Console.ReadKey();

            }
        }
    }
}
 