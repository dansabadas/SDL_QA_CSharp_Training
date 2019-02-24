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

        public class point3D : point2D
        {
            private double _z;

            public point3D(double x, double y, double z) : base(x, y)

            {
                _z = z;
            }

            public object Z => _z;
            
            public double DistanceTo3(double a, double b, double c)
            {
                double distance = Math.Sqrt((a - _x) * (a - _x) + (b - _y) * (b - _y) + (c - _z) * (c - _z));
                return distance;
            }
        }
    }
      
    public interface IGeometryFactory
    {
        ArrayList GetMyPoints();
        ArrayList GetRandomPoint3D(int x, int y, int z);
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

        public ArrayList GetRandomPoint3D(int x, int y, int z)
        {
            ArrayList myList3D = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                point2D.point3D point = new point2D.point3D(random.NextDouble(), random.NextDouble(), random.NextDouble()); 
                myList3D.Add(point);
            }

            return myList3D; 
        }
    }
        class Program
        {
        public static double Z { get; private set; }

        static void Main(string[] args)
            {
                Console.WriteLine("Calculam distanta dintre doua numere 2D");
                Console.WriteLine("cream primul punct ");                           
                point2D myFisrtPoint2D = new point2D(12, -14);
                Console.WriteLine($"{ myFisrtPoint2D.X},{ myFisrtPoint2D.Y}");
                
                Console.WriteLine("cream al doilea punct");
                point2D mySecondPoint2D = new point2D(4, 8);
                Console.WriteLine($"{mySecondPoint2D.X}, {mySecondPoint2D.Y}");

                Console.WriteLine("afisam distanta");
                Console.WriteLine($"{myFisrtPoint2D.DistanceTO(mySecondPoint2D.X, mySecondPoint2D.Y)}");

            //// afisez niste numere 3D, doar pt verificare 
            //Points PunctGeometric = new Points();
            //ArrayList myListOfPoints = PunctGeometric.GetRandomPoint3D(3, 4, 5);
            //foreach (point2D.point3D punct in myListOfPoints)
            //{
            //    Console.WriteLine($"{punct.X}, {punct.Y}, {punct.Z}");


            Console.WriteLine("Calculam distanta dintre doua numere 3D");
            point2D.point3D firstPoint = new point2D.point3D(5, 4, 1);
            Console.WriteLine($"primul punct: { firstPoint.X}, { firstPoint.Y}, { firstPoint.Z}");
            point2D.point3D secondPoint = new point2D.point3D(1, 1, 1);
            Console.WriteLine($"al doilea punct: { secondPoint.X}, { secondPoint.Y}, { secondPoint.Z}");
            Console.WriteLine("afisam distanta dintre cele 2 puncte cu 3 coordonate: ");
            Console.WriteLine($"{firstPoint.DistanceTo3(secondPoint.X,secondPoint.Y, Z)}");

            Console.ReadKey();

            }
        }
    }

 