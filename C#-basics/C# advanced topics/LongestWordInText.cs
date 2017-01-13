using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class LongestWord
{
        static void Main()
        {

            string s, s2;
            s2 = " ";
            char[] a = new char[] { ' ' };
            Console.WriteLine("Enter any string");
            s = Console.ReadLine();

            foreach (string s1 in s.Split(a))
            {
                if (s2.Length < s1.Length)
                {
                    s2 = s1;
                }
            }
            Console.WriteLine("The largest string is " + s2 + " and its length is " + s2.Length);
            Console.ReadKey();
        }
}
