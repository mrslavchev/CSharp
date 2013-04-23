using System;

class TenRandomNumbers
{
    static void Main(string[] args)
    {
        Random randomNUmbers = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(randomNUmbers.Next(100,201));
        }
    }
}

