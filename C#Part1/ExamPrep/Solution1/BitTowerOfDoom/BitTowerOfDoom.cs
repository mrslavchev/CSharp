using System;

// not done 0 points 
class BitTowerOfDoom
{
    public static void WriteTower(int[,] matrix)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write(matrix[rows, cols]);
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int[,] tower = new int[8, 8];
        int beginCount = 0;
        int curFloor = 0;
        int curPosition = 0;
        int destFloor = 0;
        int destPos = 0;
        for (int row = tower.GetLength(0) - 1; row >= 0; row--)
        {
            int num = int.Parse(Console.ReadLine());
            for (int col = 0; col < tower.GetLength(1); col++)
            {
                if ((((num >> 7 - col) & 1) == 1))
                {
                    tower[row, col] = 1;
                    beginCount++;
                }
                else
                {
                    tower[row, col] = 0;
                }
            }
        }

        bool isInBounds = (((curFloor >= 1) && (curFloor <= 6)) && ((curPosition >= 1) && (curPosition >= 6)))
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "select")
            {
                curFloor = int.Parse(Console.ReadLine());
                curPosition = int.Parse(Console.ReadLine());
            }
            else if (input == "kill")
            {
                destFloor = int.Parse(Console.ReadLine());
                destPos = int.Parse(Console.ReadLine());
                tower[curFloor, curPosition] = 0;
                curFloor = 0;
                curPosition = 0;
                if (((tower[destFloor, destPos] & tower[destFloor, destPos + 1] ) == 1) &&
                   ((tower[destFloor, destPos] & tower[destFloor, destPos - 1]) == 1) && isInBounds)
                {
                    tower[destFloor, destPos] = 0;
                }
                else if ((tower[destFloor, destPos] & tower[destFloor, destPos + 1] ) == 1 && curPosition >= 1)
                {
                    tower[destFloor, destPos] = 0;
                    tower[destFloor, destPos + 1] = 0;
                }
                else if ((tower[destFloor, destPos] & tower[destFloor, destPos - 1] ) == 1)
                {
                    tower[destFloor, destPos] = 0;
                    tower[destFloor, destPos - 1] = 0;
                }

            }
            else if (input == "move")
            {
                destFloor = int.Parse(Console.ReadLine());
                destPos = int.Parse(Console.ReadLine());
                tower[curFloor, curPosition] = 0;
                curFloor = 0;
                curPosition = 0;
                if (((tower[destFloor, destPos] & tower[destFloor, destPos + 1]) == 1) &&
                   ((tower[destFloor, destPos] & tower[destFloor, destPos - 1]) == 1))
                {
                    tower[destFloor, destPos] = 0;
                }
                else if ((tower[destFloor, destPos] & tower[destFloor, destPos + 1]) == 1)
                {
                    tower[destFloor, destPos] = 0;
                    tower[destFloor, destPos + 1] = 0;
                }
                else if ((tower[destFloor, destPos] & tower[destFloor, destPos - 1]) == 1)
                {
                    tower[destFloor, destPos] = 0;
                    tower[destFloor, destPos - 1] = 0;
                }
            }
            else if (input == "end")
            {
                break;
            }
        }

        int finalCount = 0;
        for (int row = 0; row < tower.GetLength(0); row++)
        {
            for (int col = 0; col < tower.GetLength(1); col++)
            {
                if (tower[row, col] == 1)
                {
                    finalCount++;
                }
            }
        }
        Console.WriteLine(finalCount);
    }
}

