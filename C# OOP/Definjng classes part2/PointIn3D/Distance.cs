using System;

/// <summary>
/// Contains methods for calculating distance in 3D.
/// </summary>
class Distance
{
    /// <summary>
    /// Calciulates distance between 2 points in 3D space.
    /// </summary>
    /// <param name="firstPoint">Point</param>
    /// <param name="secondPoint">Point</param>
    /// <returns>double distance</returns>
    public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
    {
        /* We are using extended version of Pitagorean theoreme where distance between 2 points is equal to 
         * sqrt((ax - bx)^2 + (ay - by)^2 )
         * ^2 denotes a sqaure.
         */
        double distance = 0;
        double squareX = (firstPoint.coordX - secondPoint.coordX) * (firstPoint.coordX - secondPoint.coordX);
        double squareY = (firstPoint.coordY - secondPoint.coordY) * (firstPoint.coordY - secondPoint.coordY);
        double squareZ = (firstPoint.coordZ - secondPoint.coordZ) * (firstPoint.coordZ - secondPoint.coordZ);
        distance = Math.Sqrt(squareX + squareY + squareZ);
        return distance;
    }
}

