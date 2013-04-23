using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Please type a circle's radius:");
        double rad = double.Parse(Console.ReadLine());
        double area = (Math.PI * rad * rad);
        double p = (2 * Math.PI * rad);
        Console.WriteLine("And your circle's area is {0}, and its perimeter is {1}",area,p);
    }
}

