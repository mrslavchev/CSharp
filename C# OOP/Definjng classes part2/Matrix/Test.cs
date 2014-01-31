using System;
using System.Threading;

class Test
{
    static void Main(string[] args)
    {
        Matrix<int> mat = new Matrix<int>(5, 5);
        Matrix<int> mat2 = new Matrix<int>(5, 5);
        FillRandomMatrix(mat);
        FillRandomMatrix(mat2);
        Matrix<int> sum = mat + mat2;
        Matrix<int> extraction = sum - mat2; // Should be equal to mat if everything's working fine.
        Matrix<int> multiplication = mat * mat2;

        Console.WriteLine(mat.ToString());
        Console.WriteLine(mat2.ToString());
        Console.WriteLine("Sum is:\n{0}", sum.ToString());
        Console.WriteLine("Extraction is:\n{0}", extraction.ToString());
        Console.WriteLine("Multiplication is:\n{0}", multiplication.ToString());
        //mat[0, 0] = 0;
        if (mat)
        {
            Console.WriteLine("First matrix contains zero");
        }
        if (mat2)
        {
            Console.WriteLine("Second matrix contains zero");
        }
    }

    public static void FillRandomMatrix(Matrix<int> matrix)
    {
        for (int row = 0; row < matrix.Rows; row++)
        {
            Random random = new Random((int)DateTime.Now.Ticks & (0x0000FFFF + row));
            for (int col = 0; col < matrix.Cols; col++)
            {              
                matrix[row, col] = random.Next(0, 100);
            }

            // Brute force way to force randomness feed.
            Thread.Sleep(10);
        }
    }
}

