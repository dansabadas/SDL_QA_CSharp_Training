using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class GeometryFactory : iGeometryFactory
    {
        Random rnd = new Random();

        public ArrayList GetMyPoints(int points)
        {

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < points; i++)
            {
                Point2D point2D = new Point2D(rnd.Next(0, points), rnd.Next(0, points));

                arrayList.Add(point2D);

            }
            return arrayList;
        }

        public Point2D GetRandomPoint(int maxX, int maxY)
        {
            Point2D point = new Point2D(rnd.NextDouble() * maxX, rnd.NextDouble() * maxY);

            return point;

        }

        public Point3D GetRandomPoint(int maxX, int maxY, int maxZ)
        {
            Point3D point = new Point3D(rnd.NextDouble() * maxX, rnd.NextDouble() * maxY, rnd.NextDouble() * maxZ);

            return point;
        }

        public double CalculateDistance(Point2D point2D)
        {
            double result = (point2D.X - point2D.Y);
            if (result < 0)
            {
                return result * -1;
            }
            else
            {
                return result;
            }
            
        }

        public double CalculateDistance(Point3D point3D)
        {
            double result = (point3D.X - point3D.Y - point3D.Z - point3D.X) * -1;
            if (result < 0)
            {
                return result * -1;
            }
            else
            {
                return result;
            }
        }
    }
}
