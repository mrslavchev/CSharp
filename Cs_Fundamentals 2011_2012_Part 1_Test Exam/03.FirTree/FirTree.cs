using System;


class triangle_class
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        DrawTree(input);
        DrawStump(input);
    }

    private static void DrawStump(int input)
    {
        for (int rows = 1; rows < 2; rows++)
        {
            for (int j = 0; j < input - rows - 1; j++)
            {
                Console.Write(".");
            }

            for (int k = 1; k <= rows * 2 - 1; k++)
            {

                if ((k == 1) && (rows == 1))
                {
                    Console.Write("*");
                    break;
                }
                else
                {
                    Console.Write("*");
                }
            }

            for (int j = 0; j < input - rows - 1; j++)
            {
                Console.Write(".");
            }

            Console.WriteLine("");
        }
    }

    private static void DrawTree(int input)
    {
        for (int rows = 1; rows < input; rows++)
        {
            for (int j = 0; j < input - rows - 1; j++)
            {
                Console.Write(".");
            }

            for (int k = 1; k <= rows * 2 - 1; k++)
            {

                if ((k == 1) && (rows == 1))
                {
                    Console.Write("*");
                    break;
                }
                else
                {
                    Console.Write("*");
                }
            }

            for (int j = 0; j < input - rows - 1; j++)
            {
                Console.Write(".");
            }

            Console.WriteLine("");
        }
    }
}
