using System;
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
    public struct Point2d: Ipoint
    {
        public static int OveralNumberOfPoints = 0;

        public const string ErrorMesage = "Error404";
        private double _x;
        private readonly double _y;
       
        public double X
        {
            get { return _x; }

        }
        public double Y
        {
            get { return _y; }
        }

        public Point2d(double x, double y)
        {
            _x = x;
            _y = y;

            OveralNumberOfPoints += 1;
        }

        public override string ToString()
        {
            return $"({_x},{_y})";
        }

        
    }
    
}
