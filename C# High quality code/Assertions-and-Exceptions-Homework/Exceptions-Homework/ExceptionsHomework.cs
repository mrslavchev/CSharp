﻿using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentException("Collection can not be null");
        }
        else if (arr.Length == 0)
        {
            throw new ArgumentException("Collection must have at least 1 memeber.");
        }
        if (startIndex < 0 || count < 0)
        {
            throw new ArgumentException("Start index and count must be positive numbers");
        }
        if (startIndex > arr.Length - 1)
        {
            throw new ArgumentException("Start index out of bounds");
        }
        if ((startIndex + count - 1) > (arr.Length - 1))
        {
            throw new ArgumentException("Conut value is too big and overflows the size of the collection.");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentException("String can not be null or empty");
        }
        if (count < 0)
        {
            throw new ArgumentException("Count can not be a negative number");
        }
        if ((str.Length - count) < 0)
        {
            throw new ArgumentException("Count exceeds input string's length.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static string CheckPrime(int number)
    {
        string output = "Number is prime.";
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                output = "Number is not prime.";
                break;
            }
        }

        return output;
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        //Console.WriteLine(ExtractEnding("Hi", 100));

        Console.WriteLine(CheckPrime(33));
        Console.WriteLine(CheckPrime(23));

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
