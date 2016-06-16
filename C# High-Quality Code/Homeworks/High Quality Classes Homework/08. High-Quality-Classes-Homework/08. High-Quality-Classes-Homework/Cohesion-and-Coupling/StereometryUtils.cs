namespace CohesionAndCoupling
{
    public class StereometryUtils : GeometryUtils
    {
        public static double Width { get; set; }

        public static double Height { get; set; }

        public static double Depth { get; set; }

        public static double CalculateVolume()
        {
            double volume = Width * Height * Depth;

            return volume;
        }

        public static double CalculateParallelepipedDiagonalXYZ()
        {

            double distance = CalculateDistance3D(0, 0, 0, Width, Height, Depth);

            return distance;
        }

        public static double CalculateSquareDiagonalXY()
        {
            double distance = CalculateDistance2D(0, 0, Width, Height);

            return distance;
        }

        public static double CalculateSquareDiagonalXZ()
        {
            double distance = CalculateDistance2D(0, 0, Width, Depth);

            return distance;
        }

        public static double CalculateSquareDiagonalYZ()
        {
            double distance = CalculateDistance2D(0, 0, Height, Depth);

            return distance;
        }
    }
}
