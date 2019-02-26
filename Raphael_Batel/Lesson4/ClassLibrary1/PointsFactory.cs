using Lesson4_ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_ClassLibrary
{
    public interface IPointsFactory
    {
        ArrayList GeneratePoints(int numberOfPoints);
    }

    public class PointsFactory : IPointsFactory
    {
        public ArrayList GeneratePoints(int numberOfPoints)
        {
            Random rand = new Random();

            ArrayList points = new ArrayList();
            for (int i = 0; i < numberOfPoints; i++)
            {
                Point2D p = new Point2D(10 * rand.NextDouble(), 20 * rand.NextDouble());
                points.Add(p);
            }

            return points;
        }
    }
}
