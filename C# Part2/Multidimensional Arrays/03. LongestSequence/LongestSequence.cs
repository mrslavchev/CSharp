using System;

/// <summary>
/// I am using iterative way to check all rows, columns, and diagonals.
/// It wouldn't be effective for large arrays, but since we are not aware of recursion, I think it works
/// </summary>
class LongestSequence
{
    static void Main()
    {
        string[,] matrix = new string[,]
        { 
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"}, 
            {"xx", "ho", "ha", "xx"},
        };

        string repeated = "";
        int count = 1;
        string bestRep = "";
        int bestCount = 1;
        //Trivial cases
        // Searching by rows
        #region rows  
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col == matrix.GetLength(1) - 1)
                {
                    repeated = "";
                    count = 1;
                    break;
                }
                else if (matrix[row, col] == matrix[row, col + 1])
                {
                    repeated = matrix[row, col];
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRep = repeated;
                    }
                }
                else
                {
                    repeated = "";
                    count = 1;
                }
            }
        }
        #endregion

        // Search by columns 
        #region columns
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                if (row == matrix.GetLength(0) - 1)
                {
                    repeated = "";
                    count = 1;
                    break;
                }
                else if (matrix[row, col] == matrix[row + 1, col])
                {
                    repeated = matrix[row, col];
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRep = repeated;
                    }
                }
                else
                {
                    repeated = "";
                    count = 1;
                }
            }
        }
        #endregion

        // Search diagonals 
        //These are the diagonals that start from m[row, col] and continue to m[row++, col++]
        #region left to right diags
        // The number of diagonals in matrix n x m is equal to (n + m) - 1.
        // The algorithm for moving through the diagonals is pretty much the same as in task 1c, 
        // we are making check not to exceed row 0, and we move the column in the opposite way if we reach 
        // the middle diagonal
        int diagCount = (matrix.GetLength(0) + matrix.GetLength(1)) - 1;
        for (int diag = 0; diag < diagCount; diag++)
        {
            int row = matrix.GetLength(1) - 1 - diag;
            if (row < 0)
            {
                row = 0;
            }

            int col = 0;
            if (diag >= matrix.GetLength(0))
            {
                col = diag - matrix.GetLength(1) + 1;
            }

            while (row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    repeated = matrix[row, col];
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestRep = repeated;
                    }
                }
                else
                {
                    repeated = "";
                    count = 1;
                }
                row++;
                col++;
            }
            count = 1;
        }
        #endregion

        // The are the diagonals that start from m[row, col] and continue to m[row++, col--]
        #region right to left diags
        // Algorithm is the same as previous, the logic is a bit inverted, we start from the bottom right corner
        // and move up 
        for (int diag = 0; diag < diagCount; diag++)
        {
            int row = matrix.GetLength(0) - 1 - diag;
            if (row < 0)
            {
                row = 0;
            }

            int col = matrix.GetLength(1) - 1;
            if (diag >= matrix.GetLength(0))
            {
                col = (matrix.GetLength(1) - diag) + 2;
            }

            while (row < matrix.GetLength(0) - 1 && col > 0)
            {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        repeated = matrix[row, col];
                        count++;
                        if (count > bestCount)
                        {
                            bestCount = count;
                            bestRep = repeated;
                        }
                    }
                    else
                    {
                        repeated = "";
                        count = 1;
                    }
                    row++;
                    col--;
                }
                count = 1;
        }
        #endregion

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }

        // We assume that a sequence contains at least 2 elements, meaning a sequence of length 1
        // is not a sequence.
        if (bestCount == 1)
        {
            Console.WriteLine("No sequence found!");
        }
        else
        {
            Console.WriteLine("Best sequence is:");
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write("{0}, ", bestRep);
            }
            Console.WriteLine();
        }
    }
}
