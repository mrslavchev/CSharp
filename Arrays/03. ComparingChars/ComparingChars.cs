//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class ComparingChars
{
    static void Main()
    {
        char[] firstArr = { 'a', 'r', 'r', 'a', 'y', 's' };
        char[] secondArr = {'a', 'r', 'r', 'a', 'y',};
        int matchingCount = 0;
        if (firstArr.Length>=secondArr.Length)
        {
            for (int n = 0; n < secondArr.Length; n++)
            {
                if (firstArr[n]<secondArr[n])
                {
                    Console.WriteLine("First array is earlier lixicographycally");
                    return;
                }
                else if (firstArr[n]==secondArr[n])
                {
                    matchingCount++;
                    if ((matchingCount == firstArr.Length) && (matchingCount == secondArr.Length))
                    {
                        Console.WriteLine("Both arrays are the same");
                    }

                    else if (matchingCount==secondArr.Length)
                    {
                        Console.WriteLine("Second array is earlier lixicographycally");
                    }
                }
                else
                {
                    Console.WriteLine("Second array is earlier lixicographycally");
                }
            }
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i]<secondArr[i])
                {
                    Console.WriteLine("First array  is earlier lixicographycally");
                    return;
                }
                else if (firstArr[i] == secondArr[i])
                {
                    matchingCount++;
                    if (matchingCount == firstArr.Length)
                    {
                        Console.WriteLine("First array is earlier lixicographycally");
                    }
                }
                else
                {
                    Console.WriteLine("Second array is earlier lixicographycally");
                    return;
                }
            }
        }
    }
}

