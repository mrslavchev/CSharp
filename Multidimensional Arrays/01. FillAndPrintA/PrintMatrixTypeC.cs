using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// It's good to notice we have number of diagonals equal to 2*n -1 where n is side of the matrix
/// We starti with a loop iterating the number of diagonals
/// </summary>
public class PrintMatrixTypeC
{
    public static void PrintArrayC(int n) 
    {
        int[,] matrix = new int[n, n];
        int filler = 1;
        for (int diag = 0; diag < (n * 2) - 1; diag++)
        {
            int row = n - 1 - diag;
            if (row < 0) //for the case when we move coords 0:0, we should move only by 0 row
            {
                row = 0;
            }

            int col = 0;
            if (diag >= n) //we are increasing columns when diag > n
            {
                col = diag - n + 1;
            }

            while ((row < n) && (col < n)) //filling the diagonals while in the bounderies
            {
                matrix[col, row] = filler;
                filler++;
                row++;
                col++;
            }
        }

        PrintMatrixTypeA.PrintArray(matrix);
    }
}

