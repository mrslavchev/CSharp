using System;


class SortInDescending
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        double c = double.Parse(Console.ReadLine());
        if (a>b)
        {
            if (b>c)
            {
                Console.WriteLine("In descending oreder number are {0}, {1} and {2}",a,b,c);
            }
            else
            {
                Console.WriteLine("In descending oreder number are {0}, {1} and {2}", a,c,b);
            }
        }
        else if (b>c)
        {
            if (c>a)
            {
                Console.WriteLine("In descending oreder number are {0}, {1} and {2}", b,c,a);
            }
            else
            {
                Console.WriteLine("In descending oreder number are {0}, {1} and {2}", b,a,c);
            }
        }
        else if (a>b)
        {
            Console.WriteLine("In descending oreder number are {0}, {1} and {2}", c,a,b);
        }
        else
        {
            Console.WriteLine("In descending oreder number are {0}, {1} and {2}", c, b,a);
        }
    }
}

