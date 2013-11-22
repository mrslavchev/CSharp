
using System;

/// <summary>
/// Don't touch - magic !
/// </summary>
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mid = n / 2;
        # region upper half
        for (int row = 0; row < mid; row++)
        {
            int offset = mid - 1 - row;
            for (int ldot = offset; ldot > 0; ldot--)
            {
                Console.Write(".");
            }

            for (int lslash = 0; lslash < mid - offset ; lslash++)
            {
                if ((lslash & 1) == 0)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            for (int rslash = mid - offset; rslash > 0; rslash--)
            {
                if ((rslash & 1) == 1)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            for (int rdot = offset; rdot > 0; rdot--)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        #endregion

        # region lower half
        for (int row = 0; row < mid; row++)
        {
            for (int ldot = 0; ldot < row ; ldot++)
            {
                Console.Write(".");
            }

            for (int lslash = 0; lslash < mid - row; lslash++)
            {
                if ((lslash & 1) == 0)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            for (int rslash = mid - row; rslash > 0; rslash--)
            {
                if ((rslash & 1) == 1)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            for (int rdot = 0; rdot < row; rdot++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
        #endregion
    }
}

