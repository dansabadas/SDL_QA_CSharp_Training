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
        double X
        {
            get;
        }
        double Y
        {
            get;
        }
    }

    public struct Point2D : IPoint
    {
        public const string error = "ewnfwenfjnfwe";
        public static int overAllNoOfPoints = 0;
        public double X { get { return _x; } set { _x = value; } }
        public double Y { get { return _y; } set { _y = value; } }

        private double _x;
        private double _y;

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
            overAllNoOfPoints++;
        }
        public override string ToString()
        {
            return $"(x:{_x},y:{_y})";
        }
    }

   }
