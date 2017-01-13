using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FormattingNumbers
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            int namesMaxLength = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            Func<string, int,bool> checkLength = new Func<string, int,bool>(CheckStringLength);
            foreach (string name in names.ToList())
            {
                if (checkLength(name, namesMaxLength))
                {
                    names.Remove(name);
                }
            }
            foreach (string name in names.ToList())
            {
                Console.WriteLine(name);
            }
        }

        private static bool CheckStringLength(string name,int namesMaxLength)
        {
            return name.Length > namesMaxLength;
        }
    }
}
