//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class ComparingChars
{
    static void Main()
    {
        char[] firstArr = { 'a', 'r', 'r', 'a', 'y'};
        char[] secondArr = {'a', 'r', 'r', 'a', 'y', 's'};
        int matchingCount = 0;
        string firstEarlier = "First array is earlier lixicographycally";
        string secondEarlier = "Second array is earlier lixicographycally";
        if (firstArr.Length>=secondArr.Length)
        {
            for (int n = 0; n < secondArr.Length; n++)      // First compare arrays lengths and check whether or not
            {                                               // a char is earlier lexicographically than the other array.
                if (firstArr[n]<secondArr[n])               // If it's not and matchcount == both lengths we have same arrays
                {                                           // We repeat the same steps in the else but vice versa
                    Console.WriteLine(firstEarlier);        
                    break;                                  
                }                                          
                else if (firstArr[n] != secondArr[n])         
                {
                    Console.WriteLine(secondEarlier);
                }
                else
                {
                    matchingCount++;
                    if ((matchingCount == firstArr.Length) && (matchingCount == secondArr.Length))
                    {
                        Console.WriteLine("Both arrays are the same");
                    }
                    else if (matchingCount == secondArr.Length)
                    {
                        Console.WriteLine(secondEarlier);
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i]<secondArr[i])
                {
                    Console.WriteLine(firstEarlier);
                    break;
                }
                else if (firstArr[i] == secondArr[i])
                {
                    matchingCount++;
                    if (matchingCount == firstArr.Length)
                    {
                        Console.WriteLine(firstEarlier);
                    }
                }
                else
                {
                    Console.WriteLine(secondEarlier);
                    break;
                }
            }
        }
    }
}

