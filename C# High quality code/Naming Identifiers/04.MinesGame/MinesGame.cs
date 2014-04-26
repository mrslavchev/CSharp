using System;
using System.Collections.Generic;

/*Refactor and improve the naming in the C# source project “3. Naming-Identifiers-Homework.zip”. 
 * You are allowed to make other improvements in the code as well (not only naming) as well as to fix bugs.*/

public class MinesGame
{
    static void Main()
    {
        string inputComand = string.Empty;
        char[,] playingField = FillCells();
        char[,] bombs = PlantBombs();
        int score = 0;
        bool explode = false;
        List<Player> championList = new List<Player>(6);
        int row = 0;
        int column = 0;
        bool beginGame = true;
        const int MaxPoints = 35;
        bool gameCompleted = false;

        do
        {
            if (beginGame)
            {
                Console.WriteLine("Let's play Mines. Try to find all the non-mined positions on the playing field." +
                    "\nCommands:\n'top'- shows the score listing\n'restart'-begins new game\n'exit'-exits the game\nGood luck!!!");
                PrintField(playingField);
                beginGame = false;
            }

            Console.Write("Plese select a postion by writing row and column number, divided by space: ");
            inputComand = Console.ReadLine().Trim();
            if (inputComand.Length >= 3)
            {
                if (int.TryParse(inputComand[0].ToString(), out row) &&
                int.TryParse(inputComand[2].ToString(), out column) &&
                    row <= playingField.GetLength(0) && column <= playingField.GetLength(1))
                {
                    inputComand = "turn";
                }
            }
            switch (inputComand)
            {
                case "top":
                    PrintScore(championList);
                    break;
                case "restart":
                    playingField = FillCells();
                    bombs = PlantBombs();
                    PrintField(playingField);
                    explode = false;
                    beginGame = false;
                    break;
                case "exit":
                    Console.WriteLine("Bye, bye see you another time :)");
                    break;
                case "turn":
                    if (bombs[row, column] != '*')
                    {
                        if (bombs[row, column] == '-')
                        {
                            ChoosePosition(playingField, bombs, row, column);
                            score++;
                        }

                        if (MaxPoints == score)
                        {
                            gameCompleted = true;
                        }
                        else
                        {
                            PrintField(playingField);
                        }
                    }
                    else
                    {
                        explode = true;
                    }

                    break;

                default:
                    Console.WriteLine("Error! Wrong comand, please try again.");
                    break;
            }
            if (explode)
            {
                PrintField(bombs);
                Console.Write("You stepped on a mine, Game Over\nYour total score is: {0} " +
                    "Write a nickname, plsease: ", score);
                string nickname = Console.ReadLine();
                Player newPlayer = new Player(nickname, score);
                if (championList.Count < 5)
                {
                    championList.Add(newPlayer);
                }
                else
                {
                    for (int i = 0; i < championList.Count; i++)
                    {
                        if (championList[i].Points < newPlayer.Points)
                        {
                            championList.Insert(i, newPlayer);
                            championList.RemoveAt(championList.Count - 1);
                            break;
                        }
                    }
                }

                championList.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                championList.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                PrintScore(championList);

                playingField = FillCells();
                bombs = PlantBombs();
                score = 0;
                explode = false;
                beginGame = true;
            }
            if (gameCompleted)
            {
                Console.WriteLine("\nCongratulations you opened all 35 cells.");
                PrintField(bombs);
                Console.WriteLine("Write down your nickname, please: ");
                string bestScore = Console.ReadLine();
                Player bestPlayer = new Player(bestScore, score);
                championList.Add(bestPlayer);
                PrintScore(championList);
                playingField = FillCells();
                bombs = PlantBombs();
                score = 0;
                gameCompleted = false;
                beginGame = true;
            }
        }
        while (inputComand != "exit");
        Console.WriteLine("Made in Bulgaria. See you! :)");
        Console.Read();
    }

    private static void PrintScore(List<Player> points)
    {
        Console.WriteLine("\nPoints: ");
        if (points.Count > 0)
        {
            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine("{0}. {1} --> {2} cells",
                    i + 1, points[i].Name, points[i].Points);
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Empty list\n");
        }
    }

    private static void ChoosePosition(char[,] field,
        char[,] bombs, int row, int column)
    {
        char kolkoBombi = CalculateBombs(bombs, row, column);
        bombs[row, column] = kolkoBombi;
        field[row, column] = kolkoBombi;
    }

    private static void PrintField(char[,] board)
    {
        int row = board.GetLength(0);
        int col = board.GetLength(1);
        Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
        Console.WriteLine("   ---------------------");
        for (int i = 0; i < row; i++)
        {
            Console.Write("{0} | ", i);
            for (int j = 0; j < col; j++)
            {
                Console.Write(string.Format("{0} ", board[i, j]));
            }

            Console.Write("|");
            Console.WriteLine();
        }

        Console.WriteLine("   ---------------------\n");
    }

    private static char[,] FillCells()
    {
        int fieldRows = 5;
        int fieldCols = 10;
        char[,] board = new char[fieldRows, fieldCols];
        for (int i = 0; i < fieldRows; i++)
        {
            for (int j = 0; j < fieldCols; j++)
            {
                board[i, j] = '?';
            }
        }

        return board;
    }

    private static char[,] PlantBombs()
    {
        int rows = 5;
        int cols = 10;
        char[,] playingField = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                playingField[i, j] = '-';
            }
        }

        List<int> bombsLocations = new List<int>();
        while (bombsLocations.Count < 15)
        {
            Random randomNum = new Random();
            int bombPosition = randomNum.Next(50);
            if (!bombsLocations.Contains(bombPosition))
            {
                bombsLocations.Add(bombPosition);
            }
        }

        foreach (int loc in bombsLocations)
        {
            int col = (loc / cols);
            int row = (loc % cols);
            if (row == 0 && loc != 0)
            {
                col--;
                row = cols;
            }
            else
            {
                row++;
            }

            playingField[col, row - 1] = '*';
        }

        return playingField;
    }

    private static void FillMinesCount(char[,] field)
    {
        int col = field.GetLength(0);
        int row = field.GetLength(1);

        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < row; j++)
            {
                if (field[i, j] != '*')
                {
                    char adjacentMines = CalculateBombs(field, i, j);
                    field[i, j] = adjacentMines;
                }
            }
        }
    }

    private static char CalculateBombs(char[,] bombedField, int colIndex, int rowIndex)
    {
        int count = 0;
        int rows = bombedField.GetLength(0);
        int cols = bombedField.GetLength(1);

        if (colIndex - 1 >= 0)
        {
            if (bombedField[colIndex - 1, rowIndex] == '*')
            {
                count++;
            }
        }

        if (colIndex + 1 < rows)
        {
            if (bombedField[colIndex + 1, rowIndex] == '*')
            {
                count++;
            }
        }

        if (rowIndex - 1 >= 0)
        {
            if (bombedField[colIndex, rowIndex - 1] == '*')
            {
                count++;
            }
        }

        if (rowIndex + 1 < cols)
        {
            if (bombedField[colIndex, rowIndex + 1] == '*')
            {
                count++;
            }
        }

        if ((colIndex - 1 >= 0) && (rowIndex - 1 >= 0))
        {
            if (bombedField[colIndex - 1, rowIndex - 1] == '*')
            {
                count++;
            }
        }

        if ((colIndex - 1 >= 0) && (rowIndex + 1 < cols))
        {
            if (bombedField[colIndex - 1, rowIndex + 1] == '*')
            {
                count++;
            }
        }

        if ((colIndex + 1 < rows) && (rowIndex - 1 >= 0))
        {
            if (bombedField[colIndex + 1, rowIndex - 1] == '*')
            {
                count++;
            }
        }

        if ((colIndex + 1 < rows) && (rowIndex + 1 < cols))
        {
            if (bombedField[colIndex + 1, rowIndex + 1] == '*')
            {
                count++;
            }
        }

        return char.Parse(count.ToString());
    }

	public class Player
	{
		private string name;
		private int points;

		public string Name
		{
			get { return name; }
			private set { name = value; }
		}

		public int Points
		{
			get { return points; }
			private set { points = value; }
		}

		public Player() 
        { 
        }

		public Player(string name, int points)
		{
			this.name = name;
			this.points = points;
		}
	}
}