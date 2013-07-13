using System;

class PointWithinCircle
{
    static void Main()
    {

        double x =5;
        double y =6;
        double radius = 5;
        double z = (x * x + y * y);
        double pit = Math.Sqrt(z);
        bool within = (pit <= radius);
        Console.WriteLine(within? "The point is within the circle" : "The point is outside the circle");
        
    }
}

