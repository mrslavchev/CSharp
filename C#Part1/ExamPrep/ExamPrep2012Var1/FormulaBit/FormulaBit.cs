using System;

class FormulaBit
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[8, 8];
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int input = int.Parse(Console.ReadLine());
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = (input >> (col)) & 1;
            }
        }

        //for (int row = 0; row < 8; row++)
        //{
        //    for (int col = 0; col < 8; col++)
        //    {
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}

        int rows = 0;
        int cols = 0;
        int count = 0;
        int turns = 0;
        bool exitReached = false;
        string direction = "down";
        string lastDirection = "down";

        while (true)
        {
            if (matrix[rows, cols] == 1)
            {
                break;
            }

            count++;

            if ((rows == 7) && (cols == 7))
            {
                exitReached = true;
                break;
            }

            if (direction == "down" && ((rows + 1 > 7 ) || matrix[rows+1, cols] == 1) )
            {
                direction = "left";
                lastDirection = "down";
                turns++;
                if ((cols + 1 > 7) || matrix[rows, cols +1] == 1)
                {
                    break;
                }
            }
            else if (direction == "up" && ((rows -1 < 0) || matrix[rows -1, cols] == 1))
            {
                direction = "left";
                lastDirection = "up";
                turns++;
                if ((cols + 1 > 7) || matrix[rows, cols + 1] == 1)
                {
                    break;
                }
            }
            else if (direction == "left" && lastDirection == "down" && (cols + 1 > 7 || matrix[rows, cols + 1] == 1))
            {
                direction = "up";
                turns++;
                if (rows -1 < 0 || matrix[rows -1, cols] == 1)
                {
                    break;
                }
            }
            else if (direction == "left" && lastDirection == "up" && (cols + 1 > 7 || matrix[rows, cols + 1] == 1))
            {
                direction = "down";
                turns++;
                if (rows + 1 > 7 || matrix[rows +1, cols] == 1)
                {
                    break;
                }
            }

            if (direction == "down")
            {
                rows++;
            }
            else if (direction == "left")
            {
                cols++;
            }
            else if (direction == "up")
            {
                rows--;
            }
        }

        if (exitReached)
        {
            Console.WriteLine(count + " " + turns);
        }
        else
        {
            Console.WriteLine("No " + count);
        }
    }
}

