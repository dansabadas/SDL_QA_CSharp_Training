using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Point3D : Point2D
    {
        protected double _z;

        public double Z
        {
            get => _z;
            set => _z = value;
        }

        public Point3D(double x, double y, double z) : base(x, y)
        {
            _z = z;
        }

        public override string ToString()
        {
            return $"(X:{_x}, Y:{_y} Z:{_z})";
        }
    }
}
