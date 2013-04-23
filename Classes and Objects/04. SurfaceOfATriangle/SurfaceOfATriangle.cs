using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SurfaceOfTriangle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select metod to calculate the surface of a triangle");
        Console.WriteLine("1-side and an altitude to it\n2-three sides\n3-two sides and an angle between them");
        sbyte select = sbyte.Parse(Console.ReadLine());
        switch (select)
        {
            case 1:
                Console.WriteLine("Enter side (in mm)");
                decimal side = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter altitude(in mm)");
                decimal altitude = decimal.Parse(Console.ReadLine());
                decimal surface = SideAltitude(side, altitude);
                Console.WriteLine("The surface is: {0:0.00} in mm", surface);
                break;

            case 2:

                Console.WriteLine("Enter side A(in mm)");
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B(in mm)");
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side C(in mm)");
                double sideC = double.Parse(Console.ReadLine()); ;
                double surfaceSecond = ThreeSides(sideA, sideB, sideC);
                Console.WriteLine("The surface is: {0:0.00} in mm", surfaceSecond);
                break;

            case 3:

                Console.WriteLine("Enter side A(in mm)");
                decimal firstSide = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B(in mm)");
                decimal secondSide = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter angle(in grad)");
                decimal angle = decimal.Parse(Console.ReadLine());
                decimal surfaceThree = TwoSideAngle(firstSide, secondSide, angle);
                Console.WriteLine("The surface is: {0:0.00} in mm", surfaceThree);
                break;

            default:

                Console.WriteLine("Your choice is not correct");
                break;
        }
    }

    static double ThreeSides(double sideA, double sideB, double sideC)
    {
        double perimetar = ((sideA + sideB + sideC) / 2);
        double surface = Math.Sqrt((perimetar * (perimetar - sideA) * (perimetar - sideB) * (perimetar - sideC)));
        return surface;
    }

    static decimal TwoSideAngle(decimal sideA, decimal sideB, decimal angle)
    {
        angle = ((angle * 180) / (decimal)Math.PI);
        decimal surface = (sideA * sideB * (Math.Sign(angle))) / 2;
        return surface;
    }

    static decimal SideAltitude(decimal side, decimal altitude)
    {
        decimal surface = (side * altitude) / 2;
        return surface;
    }
}