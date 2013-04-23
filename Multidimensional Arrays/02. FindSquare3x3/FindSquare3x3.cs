﻿using System;


    class FindSquare3x3
    {
        static int[,] matrix;

        static void Main(string[] args)
        {
            //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
            int row = 0,
                col = 0;
            row = int.Parse(Console.ReadLine());
            col = int.Parse(Console.ReadLine());
            matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int currentSum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i <= row - 3; i++)
            {
                for (int j = 0; j <= col - 3; j++)
                {
                    currentSum = SumInSquare(i, j);
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }

        static int SumInSquare(int rowIndex, int colIndex)
        {
            int result = 0;

            for (int i = rowIndex; i < 3 + rowIndex; i++)
            {
                for (int j = colIndex; j < 3 + colIndex; j++)
                {
                    result += matrix[i, j];
                }
            }

            return result;
        }
    }
