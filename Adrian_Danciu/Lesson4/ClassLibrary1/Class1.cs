using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface Ipoint
    {
        double X { get; }
        double Y { get; }

    }

    public interface IPointsFactory
    {
        ArrayList GeneratePoints(int numberOfPoints);
    }

    public class PointsFactory : IPointsFactory
    {

        public ArrayList GeneratePoints(int numberOfPoints)

        {
            ArrayList points = new ArrayList();

            for (int i = 0; i < numberOfPoints; i++)
            {

                Random rand = new Random();
                Point2D p = new Point2D(rand.NextDouble() * 10, rand.NextDouble() * 10);
                points.Add(p);
            }
            return points;

        }
   

    
    }
    public class Point2D : Ipoint
    {

        public static int OverallNumberOfPoints = 0;

        public const string errorMessage = "Bla Bla error";
        public double X { get; set; }
        public double Y { get; set; }
        //private readonly double Y { get; set; }


        public Point2D(double x, double y)
        {
            X = x;
            Y = y;

            OverallNumberOfPoints ++;
        }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
      
}