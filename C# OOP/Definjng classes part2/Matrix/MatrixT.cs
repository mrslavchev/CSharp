using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

public class Matrix<T> : IEnumerable<T>
    where T : IComparable, new()
{
    private int rows;

    public int Rows
    {
        get { return rows; }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format("Invalid row value {0}", value));
            }
            else
            {
                this.rows = value;
            }
        }
    }
    private int cols;

    public int Cols
    {
        get { return cols; }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format("Invalid col value {0}", value));
            }
            else
            {
                this.cols = value;
            }
        }
    }

    private T[,] elements;

    // Constructors

    public Matrix()
    { }

    public Matrix(int row, int col)
    {
        this.Rows = row;
        this.Cols = col;
        this.elements = new T[Rows, Cols];
    }

    // Indexer
    public T this[int rowIndex, int colIndex]
    {
        get 
        {
            if ((rowIndex < 0 || rowIndex >= Rows) || (colIndex < 0 || colIndex >= Cols))
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            return this.elements[rowIndex, colIndex];
        }
        set 
        {
            if ((rowIndex < 0 || rowIndex >= Rows) || (colIndex < 0 || colIndex >= Cols))
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            this.elements[rowIndex, colIndex] = value;
        }
    }

    // Operator overloads 
    public static Matrix<T> operator +(Matrix<T> matrix, Matrix<T> matrix2)
    {
        if ((matrix.Rows != matrix2.Rows) || (matrix.Cols != matrix2.Cols))
        {
            throw new ArgumentException("Matrix should be the same size.");
        }

        Matrix<T> result = new Matrix<T>(matrix.Rows, matrix.Cols);
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                result[row, col] = (dynamic)matrix[row, col] + matrix2[row, col];
            }
        }

        return result;
    }

    public static Matrix<T> operator -(Matrix<T> matrix, Matrix<T> matrix2)
    {
        if ((matrix.Rows != matrix2.Rows) || (matrix.Cols != matrix2.Cols))
        {
            throw new ArgumentException("Matrix should be the same size.");
        }

        Matrix<T> result = new Matrix<T>(matrix.Rows, matrix.Cols);
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                result[row, col] = (dynamic)matrix[row, col] - matrix2[row, col];
            }
        }

        return result;
    }

    public static Matrix<T> operator *(Matrix<T> matrix, Matrix<T> matrix2)
    {
        if ((matrix.Rows != matrix2.Rows) || (matrix.Cols != matrix2.Cols))
        {
            throw new ArgumentException("Matrix should be the same size.");
        }

        Matrix<T> result = new Matrix<T>(matrix.Rows, matrix.Cols);
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int col = 0; col < matrix.Cols; col++)
            {
                result[row, col] = (dynamic)matrix[row, col] * matrix2[row, col];
            }
        }

        return result;
    }

    public static bool operator true(Matrix<T> matrix)
    {
        return matrix.Contains(default(T));
    }

    public static bool operator false(Matrix<T> matrix)
    {
        return matrix.Contains(default(T));
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        for (int row = 0; row < Rows; row++)
        {
            for (int col = 0; col < Cols; col++)
            {
                builder.AppendFormat("{0} ", this.elements[row, col]);
            }

            builder.Append("\n");
        }

        return builder.ToString();
    }


    // Implementing IEnumerable to use LINQ queries.
    public IEnumerator<T> GetEnumerator()
    {
        foreach (var t in elements)
        {
            if (t == null)
            {
                break;
            }

            yield return t;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}