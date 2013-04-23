using System;

class QuadraticEquation
{
    static void Main()
    {
        double A, B, C, x1, x2, discriminant;
        Console.Write("Write \" a \" : ");
        A = double.Parse(Console.ReadLine());
        Console.Write("Write \" b \" : ");
        B = double.Parse(Console.ReadLine());
        Console.Write("Write \" c \" : ");
        C = double.Parse(Console.ReadLine());
        Console.WriteLine("The roots in the quadratic equation {0}x.x+{1}x+c=0 are:",A,B,C);
        if (A == 0)
        {
            Console.WriteLine("This isn't Quadratic equation ");
        }
        else
        {
            discriminant = B * B - (4 * A * C);
            if (discriminant < 0)
            {
                Console.WriteLine("Quadratic equation haven't a real roots, because discriminant is {0} ", discriminant);
            }
            else if (discriminant == 0)
            {
                x1 = -B / 2 * A;
                Console.WriteLine("Discriminant is 0,and root \" x1 \" is equal to \"x2\" : {0} ", x1);
            }
            else if (discriminant > 0)
            {
                x1 = (-B + Math.Sqrt(discriminant)) / 2 * A;
                x2 = (-B - Math.Sqrt(discriminant)) / 2 * A;
                Console.WriteLine("Root \"x1\" is : {0}", x1);
                Console.WriteLine("Root \"x2\" is : {0}", x2);
            }
        }

    }
}

