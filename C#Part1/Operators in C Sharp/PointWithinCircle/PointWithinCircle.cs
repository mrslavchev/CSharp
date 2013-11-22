using System;

/// <summary>
/// Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
/// </summary>
class PointWithinCircle
{
    static void Main()
    {

        double x =5;
        double y =6;
        double radius = 5;
        double z = (x * x + y * y);
        double pitagorean = Math.Sqrt(z);
        bool isWithin = (pitagorean <= radius);
        Console.WriteLine(isWithin? "The point is within the circle" : "The point is outside the circle");
        
    }
}

