using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class EqualStrings
    {
        static void Main()
        {
            string[] str = Console.ReadLine().Split();
            for (int i = 0; i < str.Length - 1; i++)
            {
                Console.Write(str[i] + " ");
                if (!str[i].Equals(str[i + 1]))
                {
                    Console.WriteLine();
                }
            }
            Console.Write(str[str.Length - 1]);
            Console.WriteLine();
        }
    }
