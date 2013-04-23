using System;

class PlusOrMinusWithoutCalc
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        double c = double.Parse(Console.ReadLine());
        bool zeroA = (a != 0);
        bool zeroB = (b != 0);
        bool zeroC = (c != 0);
        bool comp1 =(a>0);
        bool comp2 =(b>0);
        bool comp3 =(c>0);
        if (zeroA && zeroB && zeroC)
        {
            if (comp1 && comp2 && comp3)
            {
                Console.WriteLine("The result is +");
            }
            else if (!(comp1 || comp2 || comp3))
            {
                Console.WriteLine("The result is -");
            }
            else if (comp1 ^ comp2 ^ comp3)
            {
                Console.WriteLine("Result +");
            }
            else if (!(comp3 && comp2 && comp3))
            {
                Console.WriteLine("Result -");
            }
            else
            {
                Console.WriteLine("Result -");
            }
        }
        else
        {
            Console.WriteLine("Wrong input, the result is zero");
        }
    }
}

