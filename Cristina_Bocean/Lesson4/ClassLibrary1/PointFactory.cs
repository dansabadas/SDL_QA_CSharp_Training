using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ArrayList myList = new ArrayList();
            while (numberOfPoints > 0)
            {
                Random r = new Random(numberOfPoints);
                Point2D myPoint = new Point2D(r.NextDouble() * 10, r.NextDouble() * 20);
                myList.Add(myPoint);
                numberOfPoints -= 1;
            } // struct objects are allocated on the stack and 
            return myList;
        }
    }
}
