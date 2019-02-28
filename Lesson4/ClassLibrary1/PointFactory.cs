using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PointsFactory : IPointsFactory
    {
        public ArrayList GeneratePoints(int numberOfPoints)
        {
            ArrayList ar = new ArrayList();
            Random random = new Random();
            while (numberOfPoints > 0)
            {
                Point2D myPoint = new Point2D(random.NextDouble() * 10, random.NextDouble() * 20);
                ar.Add(myPoint);
                numberOfPoints -= 1;
            }
            return ar;
        }
    }

    public interface IPointsFactory
    {
        ArrayList GeneratePoints(int numberOfPoints);
    }
}
