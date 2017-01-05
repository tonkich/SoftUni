using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsHomework
{
    class nums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int first = 1;
            while (first <= n)
            {
                Console.Write("{0} ", first);
                first++;
            }
        }
    }
}
