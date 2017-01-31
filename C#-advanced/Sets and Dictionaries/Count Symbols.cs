using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string input = Console.ReadLine();
            SortedDictionarychar, int dict = new SortedDictionarychar, int();
            for (int i = 0; i  input.Length; i++)
            {
                char currentSymbol = input[i];
                if (!dict.ContainsKey(currentSymbol))
                {
                    dict[currentSymbol] = 0;
                }
                dict[currentSymbol]++;
            }
            foreach (var kvp in dict)
            {
                sb.Append(kvp.Key).Append( ).Append(kvp.Value).Append( times).Append(Environment.NewLine);

            }
            sb.ToString();
            Console.WriteLine(sb);
        }
    }
}