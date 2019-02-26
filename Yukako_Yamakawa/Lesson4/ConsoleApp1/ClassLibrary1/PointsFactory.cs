using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
        public interface IPoinsFactory
        {
            ArrayList GeneratePoints(int numberOfPoints);
        }
        public class PointsFactory : IPoinsFactory
        {
        public ArrayList GeneratePoints(int numberOfPoints)
        {
            ArrayList ar = new ArrayList();
            while (numberOfPoints > 0)
            {
                Random rand = new Random(numberOfPoints);
                Point2D myPoint = new Point2D(x: rand.NextDouble() * 10, y: rand.NextDouble() * 20);
                ar.Add(myPoint);
                numberOfPoints -= 1;
            }
            return ar;
        }
    }
}
