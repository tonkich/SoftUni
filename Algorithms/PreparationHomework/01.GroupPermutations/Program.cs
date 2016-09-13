using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GroupPermutations
{
    class Program
    {
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private static void GetPer(char[] list, int depthLevel, int maxDepth)
        {
            if (depthLevel == maxDepth)
            {
                Console.Write(list);
            }
            else
                for (int i = depthLevel; i <= maxDepth; i++)
                {
                    Swap(ref list[depthLevel], ref list[i]);
                    GetPer(list, depthLevel + 1, maxDepth);
                    Swap(ref list[depthLevel], ref list[i]);
                }
        }

        static void Main()
        {
            string str = "ABC";
            char[] arr = str.ToCharArray();
            GetPer(arr);
        }
    }
}
