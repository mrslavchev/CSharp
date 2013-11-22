using System;

/// <summary>
/// Write a program that reads an integer number n from the console and prints all 
/// the numbers in the interval [1..n], each on a single line.
/// </summary>
class PrintNumbers1toN
{
    static void Main()
    {
        Console.WriteLine("Write a number to see which ones are between 1 and it:");
        string n = Console.ReadLine();
        int number;
        int i = 1;
        bool valid = int.TryParse(n,out number); //checking if the type matches
        if (valid)
        {
            if (number>0) //checking if the number is possitive or negative 
            {
                while (i <= number)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
            else if (number < 0) //checking if the number is possitive or negative 
            {
                 while (i >= number)
                 {
                     Console.WriteLine(i);
                     i--;
                 }
            }
            else
            {
                Console.WriteLine("The number can't be 0");
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }


    }
}

