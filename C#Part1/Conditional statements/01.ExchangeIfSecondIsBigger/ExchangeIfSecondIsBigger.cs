using System;

/// <summary>
/// Write an if statement that examines two integer variables and 
/// exchanges their values if the first one is greater than the second one.
/// </summary>
class ExchangeIfSecondIsBigger
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive number:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another positive number:");
        int num2 = int.Parse(Console.ReadLine());
        int num3 = num2;
        if ((num1+num2)<=0)
        {
            Console.WriteLine("Wrong input");
            return;
        }
        if (num1>num2)
        {
            num2 = num1;
            num1 = num3;
            Console.WriteLine("The values are : first number {0}, second {1}",num1, num2);

        }
        else
        {
            Console.WriteLine("The values are : first number {0}, second {1}",num1, num2);
        }
    }
}

