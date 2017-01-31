using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            HashSet<string> hashset = new HashSet<string>();
            string input = Console.ReadLine();
            for (int i = 0; i < N; i++)
            {
                hashset.Add(input);
                input = Console.ReadLine();
            }
            string output = string.Join(Environment.NewLine, hashset);
            Console.WriteLine(output);
        }
    }
}