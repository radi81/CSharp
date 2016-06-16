using System;
using _1.Point3D;
using System.Collections.Generic;

namespace _3.Paths
{
    public class Program
    {
        public static void Main()
        {

            Path3D path = new Path3D(
                new Point3D(1, 2, 3),
                new Point3D(1, -2, 5),
                new Point3D(0, 5, -3),
                new Point3D(-11, -7, 4),
                new Point3D(6, 3, 7));

            Storage.SavePath("..\\..\\Path.xml", path);

            Path3D path0 = Storage.LoadPath("..\\..\\Path.xml");
        } 
    }
}
