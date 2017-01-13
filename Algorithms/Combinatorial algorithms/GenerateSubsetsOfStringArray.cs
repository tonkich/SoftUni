using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GenerateSubsetsOfStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string[] arr  = new string[] { "test", "rock", "fun" };
            combinations2(arr, k, 0, new string[k]);
        }

        static void combinations2(string[] arr, int k, int startPosition, string[] result)
        {
            if (k == 0)
            {
                foreach (var item in result)
                {
                    Console.Write(item + ", ");
                }
                return;
            }
            for (int i = startPosition; i <= k; i++)
            {
                result[result.Length-k] = arr[i];
                foreach (var item in result)
                {
                    Console.Write(item + ", ");
                }
                combinations2(arr, k - 1, i + 1, result);
            }
        }
    }
}
