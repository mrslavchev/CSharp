using System;
using System.Numerics;

/// <summary>
/// Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
/// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
/// Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
/// </summary>
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

