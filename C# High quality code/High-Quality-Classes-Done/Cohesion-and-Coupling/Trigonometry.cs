using System;

namespace CohesionAndCoupling
{
    static class Trigonometry
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        /// <summary>
        /// Changed acces modifier to internal for all static methods 
        /// </summary>
        internal static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        internal static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }
        internal static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        internal static double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        internal static double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, Width, Height);
            return distance;
        }

        internal static double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(0, 0, Width, Depth);
            return distance;
        }

        internal static double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(0, 0, Height, Depth);
            return distance;
        }
    }
}
