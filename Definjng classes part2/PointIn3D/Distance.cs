using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = 0;
            double squareX = (firstPoint.coordX - secondPoint.coordX) * (firstPoint.coordX - secondPoint.coordX);
            double squareY = (firstPoint.coordY - secondPoint.coordY) * (firstPoint.coordY - secondPoint.coordY);
            double squareZ = (firstPoint.coordZ - secondPoint.coordZ) * (firstPoint.coordZ - secondPoint.coordZ);
            distance = Math.Sqrt(squareX + squareY + squareZ);
            return distance;
        }
    }

