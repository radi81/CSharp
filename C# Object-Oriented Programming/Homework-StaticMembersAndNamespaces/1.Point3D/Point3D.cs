using System;

namespace _1.Point3D
{
    public class Point3D
    {
        private double coordX;
        private double coordY;
        private double coordZ;

        private static readonly double startCoordX = 0;
        private static readonly double startCoordY = 0;
        private static readonly double startCoordZ = 0;

        public Point3D(double coordX, double coordY, double coordZ)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.coordZ = coordZ;
        }

        public Point3D() : this(0, 0, 0)
        { }
        
        public static double StartCoordX
        {
            get
            {
                return Point3D.startCoordX;
            }
        }
        
        public static double StartCoordY
        {
            get
            {
                return Point3D.startCoordY;
            }
        }    

        public static double StartCoordZ
        {
            get
            {
                return Point3D.startCoordZ;
            }
        }

        public double CoordX
        {
            get { return this.coordX; }
            set { this.coordX = value; }
        }

        public double CoordY
        {
            get { return this.coordY; }
            set { this.coordY = value; }
        }
    
        public double CoordZ
        {
            get { return this.coordZ; }
            set { this.coordZ = value; }
        }

        public override string ToString()
        {
            string result = "{" + string.Format("{0}, {1}, {2}",
                this.CoordX, this.CoordY, this.CoordZ) + "}";
            return result;
        }

      
    }
}
