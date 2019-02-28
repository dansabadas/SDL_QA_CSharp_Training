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

    public struct Point2D : IPoint
    {
        public static int OverallNumberOfPoints = 0;
        public const string ErrorMessage = "bla bla error";

        private double _x { get; set; }
        private readonly double _y;

        public double X
        {
            get { return _x; }
            set { }
        }

        public double Y
        {
            get { return _y; }
            set { }
        }

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
            OverallNumberOfPoints += 1;
        }

        public override string ToString()
        {
            return $"X=({_x}), Y=({_y})";
        }

    }
}
