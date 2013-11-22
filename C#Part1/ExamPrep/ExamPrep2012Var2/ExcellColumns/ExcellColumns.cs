using System;

class ExcellColumns
{
    private static string[] columns = 
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
        return Array.BinarySearch(columns, letter) + 1; // it's a zero-based array
    }

    static void Main(string[] args)
    {
        long sum = 0;
        int len = int.Parse(Console.ReadLine());
        for (int i = 0; i < len; i++)
        {
            long input = FindValue(Console.ReadLine());
            sum += input * (long)Math.Pow(26,(len - 1 - i));
        }

        Console.WriteLine(sum);
    }
}

