using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_2D
{
    class Program
    {
        static void Main(string[] args)
        {

            Point2D first2D = new Point2D(2, 5);
            Point2D second2D = new Point2D(5, 7);
            Point3D first3D = new Point3D(3, 4, 5);
            Point3D second3D = new Point3D(6, 9, 2);

            IGeometryFactory geo = new Implementation();
            var distance2D = geo.GetDistance2Points_2D(first2D, second2D);
            Console.WriteLine("2D distance is " + distance2D);

            var distance3D = geo.GetDistance2Points_3D(first3D, second3D);
            Console.WriteLine("3D distance is " + distance3D);

        }

        public class Point2D
    {
        public Point2D() { }
        public double X { get { return _x; } set { _x = value; } }
        public double Y { get { return _y; } set { _y = value; } }

        private double _x;
        private double _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {
            return $"(x:{_x},y:{_y})";
        }
    }

    public class Point3D : Point2D
    {
        private double _z;

        public double Z
        {
            get => _z;
            set => _z = value;
        }
        public Point3D(double x, double y, double z) : base(x, y)
        {
            _z = z;
        }
    }

    public interface IGeometryFactory
    {
        double GetDistance2Points_2D(Point2D first, Point2D second);
        double GetDistance2Points_3D(Point3D first, Point3D second);

    }

    public class Implementation : IGeometryFactory
    {
        public double GetDistance2Points_2D(Point2D firstPoint, Point2D secondPoint)
        {
            return Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2));
        }

        public double GetDistance2Points_3D(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt(Math.Pow((firstPoint.X - secondPoint.X), 2) + Math.Pow((firstPoint.Y - secondPoint.Y), 2) + Math.Pow((firstPoint.Z - secondPoint.Z), 2));
        }


    }
    

    }
}