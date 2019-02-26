using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_ClassLibrary
{
    public interface IPoint
    {
        double X { get; }
        double Y { get; }
    }

    public struct Point2D : IPoint
    {
        public static int OverallNumberOfPointsCreated { get; private set; } = 0;

        public double X { get; set; }
        public double Y { get; set; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;

            OverallNumberOfPointsCreated++;
        }

        public double CalculateDistanceTo(Point2D otherPoint)
        {
            double xDistance = this.X - otherPoint.X;
            double yDistance = this.Y - otherPoint.Y;
            return Math.Sqrt(xDistance * xDistance + yDistance * yDistance);
        }

        public override string ToString()
        {
            return $"X: {X}; Y: {Y}";
        }
    }
}
