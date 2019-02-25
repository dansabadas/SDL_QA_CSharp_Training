using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Point2D p1 = new Point2D(rand.NextDouble(), rand.NextDouble());
            Point2D p2 = new Point2D(rand.NextDouble(), rand.NextDouble());
            Console.WriteLine($"Distance between point {p1} and {p2} is {p1.CalculateDistanceTo(p2)}");

        }
    }

    class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
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

    class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double CalculateDistanceTo(Point3D otherPoint)
        {
            double xDistance = this.X - otherPoint.X;
            double yDistance = this.Y - otherPoint.Y;
            double zDistance = this.Z - otherPoint.Z;
            return Math.Sqrt(xDistance * xDistance + yDistance * yDistance + zDistance * zDistance);
        }

        public override string ToString()
        {
            return $"X: {X}; Y: {Y}; Z: {Z}";
        }
    }
}
