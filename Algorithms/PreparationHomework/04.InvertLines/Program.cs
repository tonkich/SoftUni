using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.InvertLines
{
    class Program
    {
        static int n;
        static bool[,] matrix;
        static bool[] rowInverted;
        static bool[] colInverted;

        static void Main(string[] args)
        {
            ReadMatrix();
            rowInverted = new bool[n];
            colInverted = new bool[n];

            for (int iteration = 0; iteration < 2 * n; iteration++)
            {
                List<int> whiteInColumn = (new int[n]).ToList();
                List<int> whiteInRow = (new int[n]).ToList();
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col])
                        {
                            whiteInColumn[col]++;
                            whiteInRow[row]++;
                        }
                    }

                }
                int maxRowValue = whiteInRow.Max();
                int maxColValue = whiteInColumn.Max();
                if(maxColValue == 0 && maxRowValue == 0)
                {
                    Console.WriteLine(iteration);
                    return;
                }
                if (maxRowValue > maxColValue)
                {
                    int rowNum = whiteInRow.IndexOf(maxRowValue);
                    InvertRow(rowNum);
                }
                else
                {
                    int colNum = whiteInColumn.IndexOf(maxRowValue);
                    InvertColumn(colNum);
                }

            }
            Console.WriteLine(-1);
        }

         static void InvertColumn(int colNum)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, colNum] = !matrix[row, colNum];
            }
        }

        private static void InvertRow(int rowNum)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[rowNum, col] = !matrix[rowNum, col];
            }
        }

        private static void ReadMatrix()
        {
            n = int.Parse(Console.ReadLine());
            matrix = new bool[n, n];
            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = (line[col] == 'W');
                }
            }
        }
    }
}
