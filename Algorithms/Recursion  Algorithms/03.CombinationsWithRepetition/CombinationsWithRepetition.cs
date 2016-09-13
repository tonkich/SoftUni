using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CombinationsWithRepetition
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = N;
            int[] combinations = new int[N];
            Combinations(0, 0, true,N,K,combinations);
        }

        private static void Combinations(int startValue, int depth, bool withReps, int K, int N, int[] combinations)
        {
            if (depth >= K)
            {
                Print(K,combinations);
                return;
            }

            for (int i = startValue; i < N; i++)
            {
                combinations[depth] = i;
                Combinations(withReps ? i : i + 1, depth + 1, withReps,K,N,combinations);
            }
        }

        private static void Print(int K, int[] combinations)
        {
            for (int i = 0; i < K; i++)
            {
                Console.Write(combinations[i] + 1 + " ");
            }

            Console.WriteLine();
        }
    }
}
