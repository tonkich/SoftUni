namespace _03.FormattingNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divisor = int.Parse(Console.ReadLine());
            Predicate<int> isDividable = x => x%divisor == 0;
            foreach (var x in numbers.ToList())
            {
                if (isDividable(x))
                {
                    numbers.Remove(x);
                }
            }
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}