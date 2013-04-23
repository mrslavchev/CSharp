using System;

class SequenceOfFibonacci
{
    static void Main()
    {
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal sum = 0;
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);
        for (int i = 1; i < 100; i++)
        {
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            Console.WriteLine(sum);

        }

    }
}

