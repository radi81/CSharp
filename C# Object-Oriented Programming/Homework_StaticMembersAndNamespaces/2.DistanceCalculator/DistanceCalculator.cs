using System;
using _1.Point3D;

namespace _2.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt(Math.Pow(secondPoint.CoordX - firstPoint.CoordX, 2)
                + Math.Pow(secondPoint.CoordY - firstPoint.CoordY, 2)
                + Math.Pow(secondPoint.CoordZ - firstPoint.CoordZ, 2));
            return distance;
        }
    }
}
