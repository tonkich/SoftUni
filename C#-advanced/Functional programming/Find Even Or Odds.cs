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
            List<int> OddItems = new List<int>();
            List<int> EvenItems = new List<int>();
            string firstLine = Console.ReadLine();
            int[] inputToArray = firstLine.Split().Select(int.Parse).ToArray();
            int startNumber = inputToArray[0];
            int endNumber = inputToArray[1];
            string secondLine = Console.ReadLine();
            Predicate<int> isOdd = (int x)  => x % 2 != 0;
            Predicate<int> isEven = (int x) => x % 2 == 0;
            if(secondLine=="odd")
            {
                for (int i = startNumber; i <= endNumber; i++)
                {
                    if (isOdd(i))
                    {
                        OddItems.Add(i);
                    }
                }
                Console.WriteLine(string.Join(" ",OddItems));
            }
            if (secondLine == "even")
            {
                for (int i = startNumber; i <= endNumber; i++)
                {
                    if (isEven(i))
                    {
                        EvenItems.Add(i);
                    }
                }
                Console.WriteLine(string.Join(" ", EvenItems));
            }
        }
    }
}