using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IPoint
    {
        double X { get; }
        double Y { get; }
    }

    public interface IPointsFactory
    {
        ArrayList GeneratePoints(int numberOfPoints);
    }
    public struct Point2D : IPoint 
    {
        public static int OverallNumberOfPoints = 0;

        public const string errorMessage = "bla bla error";

        private  double _x;
        private readonly double _y;

        public double X
        {
            get { return _x; }
        }
        public double Y => _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;

            OverallNumberOfPoints += 1;
        }
        public double DistanceTO(double a, double b)
        {
            double distance = Math.Sqrt((a - _x) * (a - _x) + (b - _y) * (b - _y));
            return distance;
        }

        public override string ToString()
        {
            return $"{_x } , {_y}";
        }
    }



    public class PointsFactory : IPointsFactory
    {

        public ArrayList GeneratePoints(int numberOfPoints)

        {
            ArrayList ar = new ArrayList();
            Random rand = new Random();
            while (numberOfPoints > 0)
            {
                
                Point2D myPoint = new Point2D(rand.NextDouble() * 10, rand.NextDouble() * 20);
                ar.Add(myPoint);
                numberOfPoints -= 1;

            }
            return ar;
        }
    }

}
