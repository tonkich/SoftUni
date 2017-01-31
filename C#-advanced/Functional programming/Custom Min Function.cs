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
            string input = Console.ReadLine();
            int[] inputToArray = input.Split().Select(int.Parse).ToArray();
            Func<int[], int> func = array =>  array.Min();
            int min = func(inputToArray);
            Console.WriteLine(min);
        }
    }
}
