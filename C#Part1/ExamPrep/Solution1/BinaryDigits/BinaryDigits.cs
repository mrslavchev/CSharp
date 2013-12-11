using System;
using System.Collections.Generic;

class BinaryDigits
{
    public static void WriteZero(char[,] matrix, int row, int col)
    {
        matrix[row, col] = '#';
        matrix[row, col + 1] = '#';
        matrix[row, col + 2] = '#';
        matrix[row + 1, col] = '#';
        matrix[row + 1, col + 1] = '.';
        matrix[row + 1, col + 2] = '#';
        matrix[row + 2, col] = '#';
        matrix[row + 2, col + 1] = '.';
        matrix[row + 2, col + 2] = '#';
        matrix[row + 3, col] = '#';
        matrix[row + 3, col + 1] = '#';
        matrix[row + 3, col + 2] = '#';
    }

    public static void WriteOne(char[,] matrix, int row, int col)
    {
        matrix[row, col] = '.';
        matrix[row, col + 1] = '#';
        matrix[row, col + 2] = '.';
        matrix[row + 1, col] = '#';
        matrix[row + 1, col + 1] = '#';
        matrix[row + 1, col + 2] = '.';
        matrix[row + 2, col] = '.';
        matrix[row + 2, col + 1] = '#';
        matrix[row + 2, col + 2] = '.';
        matrix[row + 3, col] = '#';
        matrix[row + 3, col + 1] = '#';
        matrix[row + 3, col + 2] = '#';
    }

    public static List<int> Bits(int num)
    {
        List<int> output = new List<int>();
        for (int i = 15; i >= 0; i--)
        {
            if (((num >> i) & 1) == 1)
            {
                output.Add(1);
            }
            else
            {
                output.Add(0);
            }
        }

        return output;
    }

    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        List<int> binary = Bits(num);   
        char[,] bins = new char[4,63];
        int dotPosition = 3;
        int listPosition = 0;
        int matrixPosition = 0;
        for (int rows = 0; rows < bins.GetLength(0); rows++)
        {
            for (int cols = 0; cols < bins.GetLength(1); cols++)
            {
                if (cols == dotPosition)
                {
                    bins[rows, cols] = '.';
                    dotPosition += 4;
                }
                else if (((cols % 4) == 0) && (rows == 0)) 
                {
                    if (binary[listPosition] == 1)
                    {
                        WriteOne(bins, rows, cols);
                        listPosition++;
                    }
                    else
                    {
                        WriteZero(bins, rows, cols);
                        listPosition++;
                    }
                }
            }

            dotPosition = 3;
        }

        #region printToConsole
        for (int rows = 0; rows < bins.GetLength(0); rows++)
        {
            for (int cols = 0; cols < bins.GetLength(1); cols++)
            {
                Console.Write(bins[rows,cols]);
            }
            Console.WriteLine();
        }
        #endregion 
    }
}

