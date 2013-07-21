using System;
using System.Linq;

/// <summary>
/// We are using separate classes for the fill of arrays and one shared method to print them
/// 
/// </summary>
    public class PrintMatrixTypeA
    {
        /// <summary>
        /// Increments local variable filler, we fill columns first than rows
        /// </summary>
        /// <param name="n">rank of the matrix</param>
        public static void PrintArrayA(int n)
        {
            int[,] matrix = new int[n, n];
            int filler = 1;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[col, row] = filler++;
                }
            }

            PrintArray(matrix);
        }
        /// <summary>
        /// Prints matrix on the console
        /// </summary>
        /// <param name="array">Takes 2 dimensional array as single parameter</param>
        public static void PrintArray(int[,] array)
        {
            for (int col = 0; col < array.GetLength(0); col++)
            {
                for (int row = 0; row < array.GetLength(1); row++)
                {
                    Console.Write(Convert.ToString(array[row, col]).PadRight(3, ' '));
                }

                Console.WriteLine();
            }
        }
    }

