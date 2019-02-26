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
        public const string ErrorMessage = "aaaaaaa"; // cannot modify anywhere else this value
        private double _x; //changed the access modifier from private to protected to be able to access it in the derived class - point3D; cannot set readonly on variables that have setter
        private readonly double _y; //struct doesn't support protected
        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;

            OverallNumberOfPoints += 1;
        }
        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0)
                    _x = -value;
                else
                    _x = value + 10;
            }
        }

        public double Y => _y;

       
        public override string ToString()
        {
            return $"({_x}, {_y})";
        }

        public double CalculateDistanceTo(Point2D secondPoint2D)
        {
            double distance = Math.Sqrt(Math.Pow((secondPoint2D._x - _x), 2) + Math.Pow((secondPoint2D._y - _y), 2));
            return distance;
        }

        
    }
}
