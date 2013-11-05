using System;



class CartesianCoordinate
{
    public static int CalculatePosition(decimal coordX, decimal coordY)
    {
        if (coordX == 0)
        {
            if (coordY == 0)
            {
                return 0;
            }
            else
            {
                return 5;
            }
        }
        else if (coordX < 0)
        {
            if (coordY < 0)
            {
                return 3;
            }
            else if (coordY > 0)
            {
                return 2;
            }
            else
            {
                return 6;
            }
        }
        else
        {
            if (coordY < 0)
            {
                return 4;
            }
            else if (coordY > 0)
            {
                return 1;
            }
            else
            {
                return 6;
            }
        }
    }

    static void Main(string[] args)
    {
        decimal inputX = decimal.Parse(Console.ReadLine());
        decimal inputY = decimal.Parse(Console.ReadLine());
        Console.WriteLine(CalculatePosition(inputX, inputY));
    }
}
