using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string compund = Console.ReadLine();
                string[] compounds = compund.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string item in compounds)
                {
                    set.Add(item);
                }
            }
            set.OrderByDescending(x=>x);
            string str = string.Join(" ", set);
            Console.WriteLine(str);
        }
    }
}