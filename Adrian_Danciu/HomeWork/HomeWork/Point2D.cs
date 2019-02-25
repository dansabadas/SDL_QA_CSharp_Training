using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Point2D
    {
        public double X;
        public double Y;


        public double CalculateDistanceTo(Point2D point2D)
        {
            double distance;

            distance = Math.Sqrt(((point2D.X - this.X) * (point2D.X - this.X)) + ((point2D.Y - this.Y) * (point2D.Y - this.Y))); 
            
            return distance;
        }

        public override string ToString()
        {
            return $"{X},{this.Y}";
        }
        
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

}
