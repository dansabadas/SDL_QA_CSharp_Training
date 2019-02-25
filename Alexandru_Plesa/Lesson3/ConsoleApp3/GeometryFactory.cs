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

        public double CalculateDistance(Point2D firstPoint2D, Point2D secondPoint2D)
        {
            double result = Math.Sqrt(Math.Pow((secondPoint2D.X - firstPoint2D.X), 2) + Math.Pow((secondPoint2D.Y - firstPoint2D.Y), 2));
            return result;
        }

        public double CalculateDistance(Point3D firstPoint3D, Point3D secondPoinf3D)
        {
            double result = Math.Sqrt(Math.Pow((secondPoinf3D.X - firstPoint3D.X), 2) + Math.Pow((firstPoint3D.Y - secondPoinf3D.Y), 2) + Math.Pow((firstPoint3D.Z- secondPoinf3D.Z), 2));
            return result;
        }
    }
}
