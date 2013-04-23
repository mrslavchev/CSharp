using System;
using System.Numerics;
class FibonacciSequence
{
    static void Main()
    {
        Console.WriteLine("Please enter how many members of the Fibonacci sequence you want to display: ");
        int count = int.Parse(Console.ReadLine());
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        Console.WriteLine(firstNumber);
        for (int i = 0; i < count; i++)
        {
            BigInteger sumNumber = (firstNumber + secondNumber);
            Console.WriteLine(sumNumber);
            secondNumber = (sumNumber + firstNumber);
            Console.WriteLine(secondNumber);
            firstNumber = (secondNumber + sumNumber);
            Console.WriteLine(firstNumber);
        }
    }
}

