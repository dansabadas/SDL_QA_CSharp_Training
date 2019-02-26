using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
    public class PointFactory : IPointFactory
    {
        public ArrayList generatePoints(int nr)
        {
            Random rnd = new Random();
            ArrayList points = new ArrayList();

            for (int point = 0; point < nr; point++)
            {
                Point2D point2D = new Point2D(rnd.NextDouble() * 10, rnd.NextDouble() * 10);
                points.Add(point2D);
            }

            return points;
        }
    }
}
