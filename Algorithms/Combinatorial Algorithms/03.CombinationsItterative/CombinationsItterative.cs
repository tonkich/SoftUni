namespace _03.CombinationsItterative
{
    using System;
    using System.Collections.Generic;

    class CombinationsItterative
    {
        public static IEnumerable<int[]> Combinations(int n, int m)
        {
            int[] result = new int[m];
            Stack<int> stack = new Stack<int>();
            stack.Push(1);

            while (stack.Count > 0)
            {
                int index = stack.Count - 1;
                int value = stack.Pop();

                while (value <= n)
                {
                    result[index++] = value++;
                    stack.Push(value);
                    if (index == m)
                    {
                        yield return result;
                        break;
                    }
                }
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            foreach (int[] c in Combinations(n, k))
            {
                for (int i = 0; i < c.Length; i++)
                {
                    Console.Write(c[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
