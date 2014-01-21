using System;
using System.Text;


class NineGagNumbers
{
    static string[] gagNumbers = new string[9] 
    {
        "-!", "**", "!!!", "&&", "&-",
        "!-", "*!!!", "&*!", "!!**!-",
    };

    private static ulong ConvertToDecimal(string str)
    {
        StringBuilder builder = new StringBuilder(str);
        ulong sum = 0;
        while (builder.Length > 0)
        {
            for (int i = 0; i < gagNumbers.Length; i++)
            {
                if (builder.ToString().StartsWith(gagNumbers[i]))
                {
                    sum = sum * 9 + (ulong)i;
                    builder.Remove(0, gagNumbers[i].Length);
                }
            }
        }

        return sum;
    }

    static void Main(string[] args)
    {
        string gagString = Console.ReadLine();
        ulong decimalValue = ConvertToDecimal(gagString);
        Console.WriteLine(decimalValue);
    }

}

