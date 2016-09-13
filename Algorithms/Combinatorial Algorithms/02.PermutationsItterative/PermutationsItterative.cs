using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PermutationsItterative
{
    class PermutationsItterative
    {
        private static int countOfPermutations = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Enumerable.Range(1, n).ToArray();
            var p = Enumerable.Repeat(0, n).ToArray();
            Console.WriteLine(string.Join(", ", a));
            Permute(a,p,n);
        }

        public static void Permute(int[] a, int[] p, int n, int i = 1)
        {
            int j;
            do
            {
                if (p[i] < i)
                {
                    if (IsOdd(i))
                    {
                        j = p[i];
                    }
                    else
                    {
                        j = 0;
                    }
                    Swap(ref a[j], ref a[i]);
                    Console.WriteLine(string.Join(", ", a));
                    p[i]++;
                    i = 1;
                }
                else
                {
                    p[i] = 0;
                    i++;
                }
            } while (i < n);
        }

        private static void Swap(ref int i, ref int j)
        {
            if (i == j)
            {
                return;
            }
            i ^= j;
            j ^= i;
            i ^= j;
        }

        private static bool IsOdd(int i)
        {
            return i % 2 != 0;
        }
    }
}
