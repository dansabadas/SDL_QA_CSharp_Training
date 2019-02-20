using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface iGeometryFactory
    {
        ArrayList GetMyPoints(int points);
        Point2D GetRandomPoint(int maxX, int maxY);
        Point3D GetRandomPoint(int maxX, int maxY, int maxZ);

        double CalculateDistance(Point2D point2D);
        double CalculateDistance(Point3D point3D);

    }
}
