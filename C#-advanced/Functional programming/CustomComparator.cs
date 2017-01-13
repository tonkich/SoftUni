namespace _03.FormattingNumbers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class MyComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if ((x % 2 == 0) && (y % 2 != 0))
            {
                return -1;
            }
            else if ((x % 2 != 0) && (y % 2 == 0))
            {
                return 1;
            }
            else
            {
                if (x > y)
                {
                    return 1;
                }
                else if (x < y)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
        public class Program
        {
            private static void Main(string[] args)
            {
                int[] numbers = Console.ReadLine().Split().Select( int.Parse).ToArray();
                Array.Sort(numbers, new MyComparer());
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
}
