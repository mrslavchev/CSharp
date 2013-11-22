
using System;
using System.Text;

class ConvertNumToText
{
    public static string ConvertToText(int number)
    {
        switch (number)
        {
            case 1: return "one";

            case 2: return "two";

            case 3: return "three";

            case 4: return "four";

            case 5: return "five";

            case 6: return "six";

            case 7: return "seven";

            case 8: return "eight";

            case 9: return "nine";
            default: throw new ArgumentException("Incorect input");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please write a number 0 to 999:");
        string input = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != 0)
            {
                output.Append(ConvertNumToText(input[i]))
            }
        }
    }
}

