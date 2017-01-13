using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
static class ReverseStrings
{
                            
            public static string ReverseString(string s)
            {
                    char[] arr = s.ToCharArray();
                    Array.Reverse(arr);
                    return new string(arr);
            }
}

class ReverseString
{
            static void Main()
            {
                    string s = Console.ReadLine();
                    Console.WriteLine(ReverseStrings.ReverseString(s));
            }
}
