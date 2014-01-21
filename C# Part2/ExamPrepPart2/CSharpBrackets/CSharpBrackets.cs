using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;


// Not done 
class CSharpBrackets
{
    public static string[] ReadInput(int count)
    {
        string[] input = new string[count];
        for (int i = 0; i < count; i++)
        {
            input[i] = Console.ReadLine();
        }

        return input;
    }

    public static void RemoveWhiteSpaces(string[] array)
    {
        string match = @"\s+";
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Regex.Replace(array[i], match, " ");
        }
    }

    static void Main(string[] args)
    {
        // X Reading the string
        // Remove white spaces 
        // Rearange 
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
        int numLines = int.Parse(Console.ReadLine());
        string indent = Console.ReadLine();
        indent = indent.Trim();
        string[] lines = ReadInput(numLines);
        RemoveWhiteSpaces(lines);
        StringBuilder builder = new StringBuilder();
        int counter = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            for (int k = 0; k < lines[i].Length; k++)
            {
                if (lines[i][k] == '{')
                {
                    builder.Append('\n');
                    builder.Append(string.Concat(Enumerable.Repeat(indent, counter)));
                    builder.Append(lines[i][k]);
                    counter++;
                    builder.Append('\n');
                    builder.Append(string.Concat(Enumerable.Repeat(indent, counter)));                    
                }
                else
                {
                    builder.Append(lines[i][k]);
                }
            }
        }
        //foreach (var item in lines)
        //{
        //    Console.WriteLine(item);
        //}
        Console.WriteLine(builder.ToString());
    }
}

