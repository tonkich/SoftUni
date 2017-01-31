using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int rows = int.Parse(numbers[0]);
            int columns = int.Parse(numbers[1]);
            char[,] matrix = new char[rows, columns];
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            int charCounter = 0;
            for (int i = rows - 1; 0 <= i; i--)
            {
                for (int j = columns - 1; 0 <= j; j--)
                {
                    if (charCounter >= wordArray.Length)
                    {
                        charCounter = 0;
                        matrix[i, j] = wordArray[charCounter];
                        charCounter++;
                    }
                    else
                    {
                        matrix[i, j] = wordArray[charCounter];
                        charCounter++;
                    }

                }
                --i;
                if (i >= 0)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        if (charCounter >= wordArray.Length)
                        {
                            charCounter = 0;
                            matrix[i, k] = wordArray[charCounter];
                            charCounter++;
                        }
                        else
                        {
                            matrix[i, k] = wordArray[charCounter];
                            charCounter++;
                        }
                    }
                }

            }
            string[] shotInfo = Console.ReadLine().Split();
            int shotRow = int.Parse(shotInfo[0]);
            int shotColumn = int.Parse(shotInfo[1]);
            int shotRadius = int.Parse(shotInfo[2]);
            for (int i = 0, k = -1; i <= shotRadius; i++, k++)
            {
                matrix[shotRow, shotColumn] = ' ';
                if (shotRow+i<=matrix.GetLength(0)-1)
                {
                    matrix[shotRow + i, shotColumn] = ' ';
                }
                if (shotRow - i >= 0)
                {
                    matrix[shotRow - i, shotColumn] = ' ';
                }
                if (shotColumn + i <= matrix.GetLength(1) - 1)
                {
                    matrix[shotRow, shotColumn + i] = ' ';
                }
                if (shotColumn - i >= 0)
                {
                    matrix[shotRow, shotColumn - i] = ' ';
                }
                if (k > 0)
                {
                    if (shotRow - k >= 0 && shotColumn + k <= matrix.GetLength(1) - 1)
                    {
                        matrix[shotRow - k, shotColumn + k] = ' ';
                    }
                    if (shotRow + k <= matrix.GetLength(0) - 1 && shotColumn - k >= 0)
                    {
                        matrix[shotRow + k, shotColumn - k] = ' ';
                    }
                    if (shotRow - k >= 0 && shotColumn - k >= 0)
                    {
                        matrix[shotRow - k, shotColumn - k] = ' ';
                    }
                    if (shotRow + k <= matrix.GetLength(0) - 1 && shotColumn + k <= matrix.GetLength(1) - 1)
                    {
                        matrix[shotRow + k, shotColumn + k] = ' ';
                    }
                }
            }
            int columnReplaceIndex = 0;
            for (int i = rows - 1; 0 <= i; i--)
            {
                for (int j = columns - 1; 0 <= j; j--)
                {
                    if (i > 1 && matrix[i, j] != ' ' && matrix[i - 1, j] == ' ')
                    {
                        columnReplaceIndex = i;
                        columnReplaceIndex--;
                        while (matrix[columnReplaceIndex, j] == ' ')
                        {
                            if (columnReplaceIndex == 0)
                            {
                                break;
                            }
                            columnReplaceIndex--;
                        }
                        matrix[i - 1, j] = matrix[columnReplaceIndex, j];
                        matrix[columnReplaceIndex, j] = ' ';

                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}