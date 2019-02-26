using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassLibrary1
{
    public interface IPointsFactory
    {
        ArrayList GeneratePoints(int numberOfPoints);
    }
    public class PointsFactory : IPointsFactory
    {

        public ArrayList GeneratePoints(int numberOfPoints)
        {
            ArrayList ar = new ArrayList();
            while (numberOfPoints > 0)
            {
                Random rand = new Random(numberOfPoints);
                Point2D myPoint = new Point2D(rand.NextDouble() * 10, rand.NextDouble() * 20);
                ar.Add(myPoint);
                numberOfPoints -= 1;

            }

            return ar;
        }
    }
}
