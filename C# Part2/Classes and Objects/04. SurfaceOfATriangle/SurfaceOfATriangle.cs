using System;
using System.Linq;

/*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.
*/
/// <summary>
/// Consists of 4 methods, one choosing the method for calculation, and 3 to calculate area by certain parameters
/// </summary>
class SurfaceOfTriangle
{
    static void Main()
    {
        Console.WriteLine("Please, select a method to calculate the surface of a triangle");
        Console.WriteLine("1 - By side and an altitude to it\n2 - By three sides\n3 - By two sides and included angle");
        sbyte select = sbyte.Parse(Console.ReadLine());
        MethodSelector(select);
    }

    /// <summary>
    /// Switches over the methods for calculating area. 
    /// </summary>
    /// <param name="select">Signed byte to select which option to perform</param>
    private static void MethodSelector(sbyte select)
    {
        switch (select)
        {
            case 1:
                Console.WriteLine("Enter side (in mm)");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter altitude(in mm)");
                double altitude = double.Parse(Console.ReadLine());
                double surface = FindSurface(side, altitude);
                Console.WriteLine("The surface is: {0:0.00} sq/mm", surface);
                break;

            case 2:
                Console.WriteLine("Enter side A(in mm)");
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B(in mm)");
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side C(in mm)");
                double sideC = double.Parse(Console.ReadLine()); ;
                double surfaceSecond = FindSurfaceThreeSides(sideA, sideB, sideC);
                Console.WriteLine("The surface is: {0:0.00} sq/mm", surfaceSecond);
                break;

            case 3:
                Console.WriteLine("Enter side A(in mm)");
                double firstSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B(in mm)");
                double secondSide = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter angle(in grad)");
                double angle = double.Parse(Console.ReadLine());
                double surfaceThree = FindSurfaceAngle(firstSide, secondSide, angle);
                Console.WriteLine("The surface is: {0:0.00} sq/mm", surfaceThree);
                break;

            default:
                Console.WriteLine("Your choice is not correct");
                break;
        }
    }

    /// <summary>
    /// Calculates surface of triangle by three sides (Heron formula)
    /// </summary>
    /// <param name="sideA">Length of triangle's first side</param>
    /// <param name="sideB">Length of triangle's second side</param>
    /// <param name="sideC">Length of triangle's third side</param>
    /// <returns>Surface in mm^2</returns>
    static double FindSurfaceThreeSides(double sideA, double sideB, double sideC)
    {
        double semiP = ((sideA + sideB + sideC) / 2);
        double surface = Math.Sqrt(semiP * ((semiP - sideA) * (semiP - sideB) * (semiP - sideC)));
        return surface;
    }

    /// <summary>
    /// Calculates surface of triangle by two sides and included angle
    /// </summary>
    /// <param name="sideA">Length of triangle's first side</param>
    /// <param name="sideB">Length of triangle's second side</param>
    /// <param name="angle">Degrees of included angle</param>
    /// <returns>Surface in mm^2</returns>
    static double FindSurfaceAngle(double sideA, double sideB, double angle)
    {
        double area = ((sideA * sideB) / 2) * Math.Sin(angle);
        return area;
    }

    /// <summary>
    /// Calculates surface of triangle by side and altitude to it.
    /// </summary>
    /// <param name="side">Length of any side of the triangle</param>
    /// <param name="altitude">Length of altitude</param>
    /// <returns>Surface in mm^2</returns>
    static double FindSurface(double side, double altitude)
    {
        double surface = (side * altitude) / 2;
        return surface;
    }
}