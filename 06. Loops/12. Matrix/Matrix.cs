using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Please enter size of matrix N: ");
        string input = Console.ReadLine();
        int n;
        int col = 1;
        int row = 1;
        bool correct = int.TryParse(input, out n);
        bool biggerThanZero = ((n > 0) && (n < 20));
        Console.WriteLine();
        if (correct && biggerThanZero)
        {
            for (row = 1; row <= n; row++)
            {
                for (col = row; col < (row + n); col++)
                {
                    Console.Write(" "+col);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Wrong input, please enter positive integer number smaller than 20");
        }
    }
}

