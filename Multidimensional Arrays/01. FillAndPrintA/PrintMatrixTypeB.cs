using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class PrintMatrixTypeB
    {
        /// <summary>
        /// Same logic, we just check if col is odd or even
        /// To fill it top-down, or bottom-up
        /// </summary>
        /// <param name="n">Rank of the matrix</param>
        public static void PrintArrayB(int n) 
        {
            int[,] matrix = new int[n, n];
            int filler = 1;
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(1); row++)
                    {
                        matrix[col, row] = filler++;
                    }
                }
                else
                {
                    for (int row = matrix.GetLength(1)-1 ; row >= 0; row--)
                    {
                        matrix[col, row] = filler++;
                    }
                }
            }

            PrintMatrixTypeA.PrintArray(matrix);
        }
    }

