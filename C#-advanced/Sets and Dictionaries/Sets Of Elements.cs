using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            string input = Console.ReadLine();
            int[] array = input.Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int first = array[0];
            int second = array[1];
            for (int i = 0; i < first; i++)
            {
                int n = int.Parse(Console.ReadLine());
                firstSet.Add(n);
            }
            for (int i = 0; i < second; i++)
            {
                int m = int.Parse(Console.ReadLine());
                secondSet.Add(m);
            }
            var thirdSet = firstSet.Intersect(secondSet);
            foreach (var item in thirdSet)
            {
                Console.Write(item+" ");
            }

        }
    }
}