using _1.Point3D;
using System.Collections.Generic;


namespace _3.Paths
{
    public class Path3D

    {
        private List<Point3D> path;

        public List<Point3D> Path
        { 
            get { return this.path; }
            set { this.path = value; }
        }

        public Path3D() 
        {
            path = new List<Point3D>();
        }

        public Path3D(params Point3D[] point)
            : this()
        {  
            this.AddPoints(point);
        }

        private List<Point3D> AddPoints(params Point3D[] points)
        {
            foreach (var point in points)
            {
                this.path.Add(point);
            }
            return this.path;
        }
    }
}
