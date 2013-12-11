using System;
using System.Collections.Generic;

class ANacci
{
    private static string[] letters = 
    {
        "A", "B", "C", "D", "E",
        "F", "G", "H", "I", "J",
        "K", "L", "M", "N", "O",
        "P", "Q", "R", "S", "T",
        "U", "V", "W", "X", "Y",
        "Z"
     };

    public static int FindValue(string letter)
    {
        return Array.BinarySearch(letters, letter) + 1; // it's a zero-based array
    }

    public static List<string> CountAbonacci(List<string> beginning, int rows)
    {
        List<string> output = beginning;
        int len = (rows - 2) * 2 + 1;
        for (int i = 0; i < len; i++)
        {
            int currentNum = FindValue(output[output.Count - 1]) + FindValue(output[output.Count - 2]);
            string newNum = "";
            if (currentNum > 26)
            {
                currentNum = currentNum % 26;
                newNum = letters[currentNum - 1];
            }
            else
            {
                newNum = letters[currentNum - 1];
            }
            output.Add(newNum);
        }

        return output;
    }

    public static void PrintAbonacci(List<string> abbonachos, int rows)
    {
        int count = 0;
        string spacer = " ";
        for (int row = 0; row < rows; row++)
        {
            if (row == 0)
            {
                Console.WriteLine(abbonachos[count]);
                count++;
            }
            else
            {
                if (count < abbonachos.Count)
                {
                    Console.Write(abbonachos[count]);
                    for (int i = 0; i < row - 2 + 1; i++)
                    {
                        Console.Write(spacer);
                    }
                    Console.WriteLine(abbonachos[count + 1]);
                    count += 2;
                }
                else
                {
                    break;
                }
            }
        }
    }

    static void Main()
    {
        List<string> input = new List<string>();
        input.Add(Console.ReadLine());
        input.Add(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        List<string> output = CountAbonacci(input, l);
        PrintAbonacci(output, l);
    }

}

