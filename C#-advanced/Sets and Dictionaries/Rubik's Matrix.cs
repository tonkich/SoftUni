using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder messages = new StringBuilder();
            string[] numbers = Console.ReadLine().Split();
            int rows = int.Parse(numbers[0]);
            int columns = int.Parse(numbers[1]);
            int[,] matrix = new int[rows, columns];
            int[,] matrixCopy = new int[rows, columns];
            int counter = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = counter;
                    matrixCopy[i, j] = counter;
                    counter++;
                }
            }
            int commandsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsNumber; i++)
            {
                string[] commandInfo = Console.ReadLine().Split();
                if (commandInfo[1]=="up")
                {
                    for (int k = 0; k < int.Parse(commandInfo[2]); k++)
                    {
                        for (int j = 0; j <matrix.GetLength(0)-1; j++)
                        {
                            if (j==0)
                            {
                                matrix[matrix.GetLength(1) - 1, int.Parse(commandInfo[0])] = matrixCopy[j, int.Parse(commandInfo[0])];
                                matrix[j, int.Parse(commandInfo[0])] = matrixCopy[j+1, int.Parse(commandInfo[0])];
                            }
                            else
                            {
                                matrix[j, int.Parse(commandInfo[0])] = matrixCopy[j+1, int.Parse(commandInfo[0])];
                            }
                            
                        }
                        for (int q = 0; q < rows; q++)
                        {
                            for (int w = 0; w < columns; w++)
                            {
                                matrixCopy[q, w] = matrix[q, w];

                            }
                        }

                    }
                }
                else if (commandInfo[1] == "down")
                {
                    for (int k = 0; k < int.Parse(commandInfo[2]); k++)
                    {
                        for (int j = 0; j < matrix.GetLength(0) - 1; j++)
                        {
                            if (j == 0)
                            {
                                matrix[j, int.Parse(commandInfo[0])] = matrixCopy[matrix.GetLength(1) - 1, int.Parse(commandInfo[0])];
                                matrix[matrix.GetLength(1) - 1, int.Parse(commandInfo[0])] = matrixCopy[matrix.GetLength(1) - 2, int.Parse(commandInfo[0])];
                            }
                            else
                            {
                                matrix[j, int.Parse(commandInfo[0])] = matrixCopy[j -1, int.Parse(commandInfo[0])];
                            }

                        }
                        for (int q = 0; q < rows; q++)
                        {
                            for (int w = 0; w < columns; w++)
                            {
                                matrixCopy[q, w] = matrix[q, w];

                            }
                        }

                    }
                }
                else if (commandInfo[1] == "left")
                {
                    for (int k = 0; k < int.Parse(commandInfo[2]); k++)
                    {
                        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                        {
                            if (j == 0)
                            {
                                matrix[int.Parse(commandInfo[0]), matrix.GetLength(0) - 1] = matrixCopy[int.Parse(commandInfo[0]),j];
                                matrix[int.Parse(commandInfo[0]),j] = matrixCopy[int.Parse(commandInfo[0]),j+1];
                            }
                            else
                            {
                                matrix[int.Parse(commandInfo[0]),j ] = matrixCopy[int.Parse(commandInfo[0]),j + 1];
                            }

                        }
                        for (int q = 0; q < rows; q++)
                        {
                            for (int w = 0; w < columns; w++)
                            {
                                matrixCopy[q, w] = matrix[q, w];

                            }
                        }

                    }
                }
                else if (commandInfo[1] == "right")
                {
                    for (int k = 0; k < int.Parse(commandInfo[2]); k++)
                    {
                        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                        {
                            if (j == 0)
                            {
                                matrix[int.Parse(commandInfo[0]), j] = matrixCopy[int.Parse(commandInfo[0]), matrix.GetLength(0) - 1];
                                matrix[int.Parse(commandInfo[0]), matrix.GetLength(0) - 1] = matrixCopy[int.Parse(commandInfo[0]), matrix.GetLength(0) - 2];
                            }
                            else
                            {
                                matrix[int.Parse(commandInfo[0]), j] = matrixCopy[int.Parse(commandInfo[0]), j - 1];
                            }

                        }
                        for (int q = 0; q < rows; q++)
                        {
                            for (int w = 0; w < columns; w++)
                            {
                                matrixCopy[q, w] = matrix[q, w];

                            }
                        }

                    }
                }
            }
            counter = 1;
            int firstNumToSwap;
            int secondNumToSwap;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j]== counter)
                    {
                        messages.Append(Environment.NewLine).Append("No swap required");
                        counter++;
                    }
                    else 
                    {
                        firstNumToSwap = matrix[i, j];
                        messages.Append(Environment.NewLine).Append($"Swap ({i}, {j}) with ");
                        for (int q = 0; q < rows; q++)
                        {
                            for (int w = 0; w < columns; w++)
                            {
                                if (matrix[q,w]==counter)
                                {
                                    messages.Append($"({q}, {w}) ");
                                    secondNumToSwap = matrix[q, w];
                                    matrix[i, j] = matrix[q, w];
                                    matrix[q, w] = firstNumToSwap;
                                    q = rows - 1;
                                    break;
                                }
                            }
                        }
                        counter++;
                    }
                }
            }
            Console.WriteLine(messages.ToString().Trim());
        }
    }
}