using System;
using _1.Point3D;

namespace _2.DistanceCalculator
{
    class Program
    {
        public static void Main()
        {
            Point3D pointX = new Point3D(1, 7, 0);
            Point3D pointY = new Point3D(0, 9, 1);
            Console.WriteLine("Distance: " + DistanceCalculator.CalculateDistance(pointX, pointY));
        }
    }
}
