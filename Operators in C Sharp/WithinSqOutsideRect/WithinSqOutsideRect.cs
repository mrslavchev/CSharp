using System;
using System.Threading;
using System.Globalization;

/// <summary>
/// Write an expression that checks for given point (x, y) 
/// if it is within the circle K( (1,1), 3) and out of the rectangle 
/// R(top=1, left=-1, width=6, height=2).
/// </summary>
class WithinSqOutsideRect
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =CultureInfo.InvariantCulture; //for the floating point separator
        Console.WriteLine("Please enter value for x:"); //defining x
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Pease enter value for y:"); //defining y
        double y = double.Parse(Console.ReadLine());
        double z =Math.Sqrt ((x-1)*(x-1)+(y-1)*(y-1)); //calculating the squares using the Pitagorean theoreme
        double rad = 3d;  //declaring radius
        bool isWithinTheCircle = (z <= rad); //comparing radius to z
        bool isInTheRectangle = ((x>=-1)&&(x<=5))&&((y>=-1)&&(y<=1)); //comparing point coordinates to rectangle sides
        Console.WriteLine(isWithinTheCircle ? "The point is within the circle" : "The point is outside the circle"); //printing results
        Console.WriteLine(isInTheRectangle ? "The point is in the rectangle" : "The point is outside of the rectangle");  
    }
}

