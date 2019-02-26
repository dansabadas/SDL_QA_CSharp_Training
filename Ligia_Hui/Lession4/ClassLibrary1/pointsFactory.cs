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
        public ArrayList Generate(int numberOfPoints)
        {
            ArrayList list = new ArrayList();

            while (numberOfPoints > 0)
            {
                Random rand = new Random();
                Point2d myPoint = new ClassLibrary1.Point2d(x: rand.NextDouble() * 10, y: rand.NextDouble() * 10);

                list.Add(myPoint);
                numberOfPoints--;
            }

            return list;
        }


    }

    public interface IPointsFactory
    {
        ArrayList Generate(int number);
    }
}
