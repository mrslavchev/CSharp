using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PrintMatrixTypeC
{
    public static void PrintArrayC(int n) 
    {
        int[,] matrix = new int[n, n];
        int filler = 1;
        for (int diag = 0; diag < (n * 2) - 1; diag++)
        {
            int row = n - 1 - diag;
            if (row < 0)
            {
                row = 0;
            }

            int col = 0;
            if (diag >= n)
            {
                col = diag - n + 1;
            }

            while ((row < n) && (col < n))
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

