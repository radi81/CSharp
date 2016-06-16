namespace CohesionAndCoupling
{
    using System;

    public class GeometryUtils
    {
        public static double CalculateDistance2D(
            double firstPointCoordX,
            double firstPointCoordY,
            double secondPointCoordX,
            double secondPointCoordY)
        {
            double distance = Math.Sqrt(
                (secondPointCoordX - firstPointCoordX) * (secondPointCoordX - firstPointCoordX) +
                (secondPointCoordY - firstPointCoordY) * (secondPointCoordY - firstPointCoordY));

            return distance;
        }

        public static double CalculateDistance3D(
            double firstPointCoordX,
            double firstPointCoordY,
            double firstPointCoordZ,
            double secondPointCoordX,
            double secondPointCoordY,
            double secondPointCoordZ)
        {
            double distance = Math.Sqrt(
                (secondPointCoordX - firstPointCoordX) * (secondPointCoordX - firstPointCoordX) +
                (secondPointCoordY - firstPointCoordY) * (secondPointCoordY - firstPointCoordY) +
                (secondPointCoordZ - firstPointCoordZ) * (secondPointCoordZ - firstPointCoordZ));

            return distance;
        }
    }
}
