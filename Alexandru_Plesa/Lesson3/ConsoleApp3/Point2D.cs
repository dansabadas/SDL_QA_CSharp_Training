using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Point2D
    {
        protected double _x;
        protected double _y;

        public double X
        {
            get => _x;
            set => _x = value;
        }
        public double Y
        {
            get => _y;
            set
            {
                if (value < 0)
                {
                    _y = value * -1;
                }
                else
                {
                    _y = value;
                }

            }
        }

        public Point2D(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"(X:{_x}, Y:{_y})";
        }
    }
}
