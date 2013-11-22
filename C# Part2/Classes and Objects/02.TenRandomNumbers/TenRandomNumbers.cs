using System;
/*Write a program that generates and prints to the console 10 random values in the range [100, 200].
*/
class TenRandomNumbers
{
    static void Main()
    {
        Random generator = new Random();
        for (int i = 0; i < 10; i++)
        {
            int ranNumber = generator.Next(100, 200);
            Console.WriteLine(ranNumber);
        }
    }
}

