using System;

public class ShipDamage
{
    public static int CalculateDamage(int hitX, int hitY, int s1X, int s1Y, int s2X, int s2Y) 
    {
        int minX = Math.Min(s1X, s2X);
        int maxX = Math.Max(s1X, s2X);
        int minY = Math.Min(s1Y, s2Y);
        int maxY = Math.Max(s1Y, s2Y);
        //corners
        if ((hitX == minX) && (hitY == minY))
        {
            return 25;
        }

        else if ((hitX == maxX) && (hitY == minY))
        {
            return 25;
        }

        else if ((hitX == maxX) && (hitY == maxY))
        {
            return 25;
        }

        else if ((hitX == minX) && (hitY == maxY))
        {
            return 25;
        }
        //inside
        else if (((hitX > minX) && (hitY > minY)) && (hitX < maxX) && (hitY < maxY))
        {
            return 100;
        }
        //sides
        else if (((hitX == minX) && ((hitY < maxY)) && (hitY > minY)) || ((hitX == maxX) && ((hitY < maxY)) && (hitY > minY)))
        {
            return 50;
        }

        else if (((hitY == minY) && ((hitX > minX)) && (hitX < maxX)) || ((hitY == maxY) && ((hitX > minX)) && (hitX < maxX)))
        {            
            return 50;
        }
        return 0;
    }

    static void Main()
    {
        int s1X = int.Parse(Console.ReadLine());
        int s1Y = int.Parse(Console.ReadLine());
        int s2X = int.Parse(Console.ReadLine());
        int s2Y = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int c1X = int.Parse(Console.ReadLine());
        int c1Y = int.Parse(Console.ReadLine());
        int c2X = int.Parse(Console.ReadLine());
        int c2Y = int.Parse(Console.ReadLine());
        int c3X = int.Parse(Console.ReadLine());
        int c3Y = int.Parse(Console.ReadLine());

        c1Y = 2 * h - c1Y;
        c2Y = 2 * h - c2Y;
        c3Y = 2 * h - c3Y;

        int damage = 0;
        damage += CalculateDamage(c1X, c1Y, s1X, s1Y, s2X, s2Y);
        damage += CalculateDamage(c2X, c2Y, s1X, s1Y, s2X, s2Y);
        damage += CalculateDamage(c3X, c3Y, s1X, s1Y, s2X, s2Y);
        Console.WriteLine(damage + "%");
    }
}