using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SumOfMatrixes
    {
        static void Main(string[] args)
        {
            var firstMatrix = new double[,] { { 1, 3 }, { 5, 7 } };
            var secondMatrix = new double[,] { { 4, 2 }, { 1, 5 } };
            var combinedMatrix = CombineMatrixes(firstMatrix, secondMatrix);

            for (int i = 0; i < combinedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < combinedMatrix.GetLength(1); j++)
                {
                    Console.Write(combinedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] CombineMatrixes(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new Exception("Error!");
            }

            var firstMatrixElements = firstMatrix.GetLength(1);
            var combinedMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int i = 0; i < combinedMatrix.GetLength(0); i++)
                for (int j = 0; j < combinedMatrix.GetLength(1); j++)
                    for (int k = 0; k < firstMatrixElements; k++)
                        combinedMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            return combinedMatrix;
        }
    }
}