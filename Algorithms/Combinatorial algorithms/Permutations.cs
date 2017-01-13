using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Permutations
{
    class Permutations
    {
        private static int countOfPermutations = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var array = Enumerable.Range(1, n).ToArray();
            Permute(array);
            Console.WriteLine($"Total permutations: { countOfPermutations}");
        }
        public static void Permute(int[] array, int startIndex=0)
        {
            if(startIndex>= array.Length-1)
            {
                Console.WriteLine(string.Join(", ", array));
                countOfPermutations++;

            }
            else
            {
                for (int i = startIndex; i < array.Length; i++)
                {
                    Swap(ref array[startIndex], ref array[i]);
                    Permute(array, startIndex+1);
                    Swap(ref array[i], ref array[startIndex]);
                }
            }
        }
        private static void Swap(ref int i, ref int j)
        {
            if(i==j)
            {
                return;
            }
            i ^= j;
            j ^= i;
            i ^= j;
        }
    }
}
