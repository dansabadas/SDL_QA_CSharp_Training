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
        public const string ErrorMessage = "Error etc..."; //once declared cannot be modified

        private double _x;
        private readonly double _y;  //only assigned once in this constructor

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;

            OverallNumberOfPoints += -1;
        }
        public double X   // it is mapped to private _x   & This is a property
        {
            get { return _x; }
            set
            {
                if (value < 0)
                {
                    _x = -value;
                }
                else
                {
                    _x = value + 10;
                }
            }
        }


        public double Y => _y;

        public override string ToString()   //inheriting the method of the object of "ToString"
        {
            return $"({this._x},{_y})"; //does not matter if "this." is added or not
        }


    }

}
