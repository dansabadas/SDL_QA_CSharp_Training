using System;
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
    public class Point2D : IPoint
    {
        public static int OverallNumberOfPoints = 0;
        protected double _x;
        protected readonly double _y;
        public const string errorMessage = "Some Random Error";

        public double X
        {
            get => _x;
            set => _x = value;
        }
        public double Y
        {
            get => _y;
            //set => _y = value;
        }

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
            OverallNumberOfPoints++;
        }

        public override string ToString()
        {
            return $"(X:{_x}, Y:{_y})";
        }
    }
}
