using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Point3D
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Starting point ");
            string startCoordinates = "{" + string.Format("{0}, {1}, {2}", Point3D.StartCoordX,
                Point3D.StartCoordY, Point3D.StartCoordZ) + "}";
            Console.WriteLine(startCoordinates);

            Point3D a = new Point3D(2.3, 4.5, 7);
            Console.Write("Current point ");
            Console.WriteLine(a);
        }
    }
}
