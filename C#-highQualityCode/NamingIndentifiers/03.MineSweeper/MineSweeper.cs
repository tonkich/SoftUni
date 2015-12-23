using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mini4ki
{
    public class Minesweeper
    {
        public class Scoreboard
        {
            private string player;

            private int points;

            public string Player
            {
                get
                {
                    return player;
                }

                set
                {
                    player = value;
                }
            }

            public int Points
            {
                get
                {
                    return points;
                }

                set
                {
                    points = value;
                }
            }

            public Scoreboard()
            {
            }

            public Scoreboard(string name, int то4ки)
            {
                this.player = name;
                this.points = то4ки;
            }
        }

        private static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] mineField = CreateMineField();
            char[,] mines = SetMines();
            int counter = 0;
            bool blown = false;
            List<Scoreboard> topPlayers = new List<Scoreboard>(6);
            int row = 0;
            int column = 0;
            bool start = true;
            const int maxPoints = 35;
            bool win = false;

            do
            {
                if (start)
                {
                    Console.WriteLine(
                        "Lets play some Minesweeper. Try your luck by not getting blown by a mine."
                        + "Command 'score' shows the scoreboard, 'restart' starts a new game, 'exit' kazva chalo lek!");
                    CreateMineFieldFrame(mineField);
                    start = false;
                }

                Console.Write("Choose row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column)
                        && row <= mineField.GetLength(0) && column <= mineField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "score":
                        ShowScore(topPlayers);
                        break;
                    case "restart":
                        mineField = CreateMineField();
                        mines = SetMines();
                        CreateMineFieldFrame(mineField);
                        blown = false;
                        start = false;
                        break;
                    case "exit":
                        Console.WriteLine("chalo lek!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                ExecuteTurn(mineField, mines, row, column);
                                counter++;
                            }

                            if (maxPoints == counter)
                            {
                                win = true;
                            }
                            else
                            {
                                CreateMineFieldFrame(mineField);
                            }
                        }
                        else
                        {
                            blown = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command input!\n");
                        break;
                }

                if (blown)
                {
                    CreateMineFieldFrame(mines);
                    Console.Write("\nYou've been killed by a mine! Score: {0} points. " + "Enter your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Scoreboard playerScore = new Scoreboard(nickname, counter);
                    if (topPlayers.Count < 5)
                    {
                        topPlayers.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < topPlayers.Count; i++)
                        {
                            if (topPlayers[i].Points < playerScore.Points)
                            {
                                topPlayers.Insert(i, playerScore);
                                topPlayers.RemoveAt(topPlayers.Count - 1);
                                break;
                            }
                        }
                    }

                    topPlayers.Sort((Scoreboard r1, Scoreboard r2) => r2.Player.CompareTo(r1.Player));
                    topPlayers.Sort((Scoreboard r1, Scoreboard r2) => r2.Points.CompareTo(r1.Points));
                    ShowScore(topPlayers);

                    mineField = CreateMineField();
                    mines = SetMines();
                    counter = 0;
                    blown = false;
                    start = true;
                }

                if (win)
                {
                    Console.WriteLine("\nGood job you've stepped on 35 cells without getting killed!");
                    CreateMineFieldFrame(mines);
                    Console.WriteLine("Enter your nickname: ");
                    string nickName = Console.ReadLine();
                    Scoreboard playerScore = new Scoreboard(nickName, counter);
                    topPlayers.Add(playerScore);
                    ShowScore(topPlayers);
                    mineField = CreateMineField();
                    mines = SetMines();
                    counter = 0;
                    win = false;
                    start = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Laughing!");
            Console.WriteLine("Come on.");
            Console.Read();
        }

        private static void ShowScore(List<Scoreboard> score)
        {
            Console.WriteLine("\nScore:");
            if (score.Count > 0)
            {
                for (int i = 0; i < score.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, score[i].Player, score[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty scoreboard!\n");
            }
        }

        private static void ExecuteTurn(char[,] mineField, char[,] mines, int row, int column)
        {
            char minesCount = OverallCellsCount(mines, row, column);
            mines[row, column] = minesCount;
            mineField[row, column] = minesCount;
        }

        private static void CreateMineFieldFrame(char[,] board)
        {
            int mineFieldRows = board.GetLength(0);
            int mineFieldColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < mineFieldRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < mineFieldColumns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateMineField()
        {
            int mineFieldRows = 5;
            int mineFieldColumns = 10;
            char[,] mineField = new char[mineFieldRows, mineFieldColumns];
            for (int i = 0; i < mineFieldRows; i++)
            {
                for (int j = 0; j < mineFieldColumns; j++)
                {
                    mineField[i, j] = '?';
                }
            }

            return mineField;
        }

        private static char[,] SetMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] mineField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mineField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!mines.Contains(asfd))
                {
                    mines.Add(asfd);
                }
            }

            foreach (int mine in mines)
            {
                int row = mine / columns;
                int column = mine % columns;
                if (column == 0 && mine != 0)
                {
                    row--;
                    column = columns;
                }
                else
                {
                    column++;
                }

                mineField[row, column - 1] = '*';
            }

            return mineField;
        }

        private static void SafeCellsCount(char[,] mineField)
        {
            int row = mineField.GetLength(0);
            int column = mineField.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (mineField[i, j] != '*')
                    {
                        char cellsCount = OverallCellsCount(mineField, i, j);
                        mineField[i, j] = cellsCount;
                    }
                }
            }
        }

        private static char OverallCellsCount(char[,] cell, int cellRow, int cellColumn)
        {
            int count = 0;
            int rows = cell.GetLength(0);
            int columns = cell.GetLength(1);

            if (cellRow - 1 >= 0)
            {
                if (cell[cellRow - 1, cellColumn] == '*')
                {
                    count++;
                }
            }

            if (cellRow + 1 < rows)
            {
                if (cell[cellRow + 1, cellColumn] == '*')
                {
                    count++;
                }
            }

            if (cellColumn - 1 >= 0)
            {
                if (cell[cellRow, cellColumn - 1] == '*')
                {
                    count++;
                }
            }

            if (cellColumn + 1 < columns)
            {
                if (cell[cellRow, cellColumn + 1] == '*')
                {
                    count++;
                }
            }

            if ((cellRow - 1 >= 0) && (cellColumn - 1 >= 0))
            {
                if (cell[cellRow - 1, cellColumn - 1] == '*')
                {
                    count++;
                }
            }

            if ((cellRow - 1 >= 0) && (cellColumn + 1 < columns))
            {
                if (cell[cellRow - 1, cellColumn + 1] == '*')
                {
                    count++;
                }
            }

            if ((cellRow + 1 < rows) && (cellColumn - 1 >= 0))
            {
                if (cell[cellRow + 1, cellColumn - 1] == '*')
                {
                    count++;
                }
            }

            if ((cellRow + 1 < rows) && (cellColumn + 1 < columns))
            {
                if (cell[cellRow + 1, cellColumn + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}