using System;
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

/// <summary>
/// Contains separate methods for reading the matrix, printing it, scan the matrix for 
/// the 3x3 square, sum the square itself, and print the result
/// </summary>
public class FindSquare3X3
{
    /// <summary>
    /// Reads matrix from the console
    /// </summary>
    /// <returns>2D array</returns>
    public static int[,] ReadMatrix()
    {

        Console.WriteLine("Please enter row size: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter col size: ");
        int cols = int.Parse(Console.ReadLine());
        if (rows < 3 || cols < 3)
        {
            Console.WriteLine("Wrong input each side should be at least 3");
        }

        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine("Type values for row {0}", i);
            for (int k = 0; k < cols; k++)
            {
                matrix[i, k] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;


    }

    /// <summary>
    /// Prints array to the console
    /// </summary>
    /// <param name="array">Takes 2D array as single parameter</param>
    public static void PrintMatrix(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write(Convert.ToString(array[i, k]).PadLeft(3, ' '));
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Calculates a sum for a 3x3 square
    /// within a 2D array
    /// </summary>
    /// <param name="array">Takes 2D array as first parameter</param>
    /// <param name="rowIndex">Takes row coordinate as second parameter</param>
    /// <param name="colIndex">Takes column coordinate as third parameter</param>  
    public static int GetSum(int[,] array, int rowIndex, int colIndex) 
    {
        int result = 0;
        for (int i = rowIndex; i < rowIndex + 3; i++)
        {
            result = result + array[i, colIndex];
            for (int k = colIndex; k < colIndex + 2; k++)
            {
                result = result + array[i, k + 1];
            }
        }

        return result;
    }

    /// <summary>
    /// Scans a matrix using the GetSum method
    /// By incrementing row and cow, we are moving the 3x3 square all over the matrix
    /// </summary>
    /// <param name="matrix">2d array</param>
    private static void ScanMatrix(int[,] matrix, out int bestSum, out int[] bestCoords)
    {
        int sum = 0;
        bestSum = int.MinValue;
        bestCoords = new int[2];
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = GetSum(matrix, row, col);
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestCoords[0] = row;
                    bestCoords[1] = col;
                    sum = 0;
                }
                else
                {
                    sum = 0;
                }
            }
        }

        PrintBestResutlt(matrix, bestCoords[0], bestCoords[1]);
    }

    /// <summary>
    /// Prints the best result found
    /// </summary>
    /// <param name="array">2d array</param>
    /// <param name="rowCor">Row coordinate</param>
    /// <param name="colCor">Column coordinate</param>
    public static void PrintBestResutlt(int[,] array, int rowCor, int colCor) 
    {
        for (int i = rowCor; i < rowCor + 3; i++)
        {
            for (int k = colCor; k < colCor + 3; k++)
            {
                Console.Write(Convert.ToString(array[i, k]).PadLeft(3, ' '));
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] inputArray = ReadMatrix();
        int bestSum =0;
        int[] bestCoords;
        Console.WriteLine("The matrix is: ");
        PrintMatrix(inputArray);
        Console.WriteLine("The best square is:");
        ScanMatrix(inputArray, out bestSum, out bestCoords);
        Console.WriteLine("The best sum is :" + bestSum);
    }

    
}
