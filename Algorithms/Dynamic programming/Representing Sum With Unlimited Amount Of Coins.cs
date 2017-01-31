using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RepresentingSumWithUnlimitedAmountOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("S = ");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter coin values separated by space:");
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int[] array = Array.ConvertAll(split, int.Parse);
            
            foreach (int[] way in GetSumWays(array, sum))
            {
                Console.WriteLine(string.Join(" ", way));
            }
        }

        public static int[][] GetSumWays(int[] array, int k)
        {
            int[][][] ways = new int[k + 1][][];
            ways[0] = new[] { new int[0] };

            for (int i = 1; i <= k; i++)
            {
                ways[i] = (
                    from val in array
                    where i - val >= 0
                    from subway in ways[i - val]
                    where subway.Length == 0 || subway[0] >= val
                    select Enumerable.Repeat(val, 1)
                        .Concat(subway)
                        .ToArray()
                ).ToArray();
            }
            return ways[k];
        }
    }
}
