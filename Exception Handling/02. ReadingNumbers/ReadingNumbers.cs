using System;

class ReadingNumbers
{
    static int ReadNumber(int start, int end)
    {
        int input = int.Parse(Console.ReadLine());
        if (input < start || input > end)
        {
            throw new ArgumentOutOfRangeException("Invalid input");
        }

        return input;
    }

    static void Main()
    {
        int min = 1, max = 100;

        for (int i = 0; i < 10; i++)
        {
            ReadNumber(min, max);
        }
    }
}