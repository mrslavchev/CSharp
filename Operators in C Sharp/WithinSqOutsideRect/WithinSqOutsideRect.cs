using System;
using System.Threading;
using System.Globalization;

class WithinSqOutsideRect
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =CultureInfo.InvariantCulture; //for the floating point separator
        Console.WriteLine("Please enter value for x:"); //defining x
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Pease enter value for y:"); //defining y
        double y = double.Parse(Console.ReadLine());
        double z =Math.Sqrt ((x-1)*(x-1)+(y-1)*(y-1)); //calculating the squares
        double rad = 3d;  //declaring radius
        bool wthnTheCirc = (z <= rad); //comparing radius to z
        bool inTheRect = ((x>=-1)&&(x<=5))&&((y>=-1)&&(y<=1)); //comparing point coordinates to rectangle sides
        Console.WriteLine(wthnTheCirc ? "The point is within the circle" : "The point is outside the circle"); //printing results
        Console.WriteLine(inTheRect ? "The point is in the rectangle" : "The point is outside of the rectangle");  
    }
}

