using System;

class BinaryDigitsCount
{
    public static int BitCounter(long input, char bit)
    {
        string bitRepresentation = Convert.ToString(input, 2);
        int counter = 0;
        for (int i = 0; i < bitRepresentation.Length; i++)
        {
            if (bitRepresentation[i] == bit)
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main(string[] args)
    {
        char bit = char.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());
        long[] numbers = new long[lines];
        for (int i = 0; i < lines; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        foreach (var item in numbers)
        {
            Console.WriteLine(BitCounter(item, bit));
        }


    }
}

