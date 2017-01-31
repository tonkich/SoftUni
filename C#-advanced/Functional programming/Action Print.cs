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
            string[] inputToArray = input.Split().ToArray();
             Action<string> action = item => Console.WriteLine(item);
            foreach (var item in inputToArray)
            {
                action(item);
            }
        }
    }
}
