using System;
using System.IO;
using System.Collections.Generic;
/*Write a program that reads a text file containing a square matrix of numbers and finds in the matrix
 * an area of size 2 x 2 with a maximal sum of its elements. 
 * The first line in the input file contains the size of matrix N. 
 * Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file*/

class SquareMatrix
{
    /// <summary>
    /// Reads matrix from text file
    /// </summary>
    /// <returns>2d matrix</returns>
    static int[,] ReadMatrix() 
    {
        using (StreamReader line = new StreamReader("../../input.txt")) 
        {
            int n = int.Parse(line.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = line.ReadLine().Split(' ');
                for (int k = 0; k < numbers.Length; k++)
                {
                    matrix[i, k] = int.Parse(numbers[k]);
                }
            }

            return matrix;
        }

    }

    /// <summary>
    /// Iterates the matrix returning the best sum.\
    /// I used this code in another task, that's why
    /// some aproaches might look odd.
    /// </summary>
    /// <param name="matrix">Takes 2d array as first parameter</param>
    /// <param name="bestSum">Returns best sum</param>
    static void ScanMatrix(int[,] matrix, out int bestSum) 
    {
        int sum = 0;
        bestSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                sum = CalcSum(matrix, row, col);
                if (sum > bestSum)
                {
                    bestSum = sum;
                    sum = 0;
                }
                else
                {
                    sum = 0;
                }
            }
        }
    }

    /// <summary>
    /// Calculates sum in 2x2 array
    /// </summary>
    /// <param name="array">Takes 2d array as first parameter</param>
    /// <param name="rowIndex">Takes row index to start from</param>
    /// <param name="colIndex">Takes column index to start from</param>
    /// <returns>Sum</returns>
    static int CalcSum(int[,] array, int rowIndex, int colIndex) 
    {
        int result = 0;
        for (int i = rowIndex; i < rowIndex + 2; i++)
        {
            result = result + array[i, colIndex];
            for (int k = colIndex; k < colIndex + 1; k++)
            {
                result = result + array[i, k + 1];
            }
        }

        return result;
    }

    /// <summary>
    /// Writes the result to file
    /// </summary>
    /// <param name="sum">Takes sum to be written</param>
    static void WriteResult(int sum) 
    {
        using (StreamWriter writer = new StreamWriter("../../output.txt"))
        {
            writer.WriteLine(sum);
        }
    }

    static void Main() 
    {
        int[,] inputArray = ReadMatrix();
        int bestSum;
        ScanMatrix(inputArray, out bestSum);
        WriteResult(bestSum);
    }
}