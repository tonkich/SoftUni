using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
class countString
{
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            Console.WriteLine("Enter substring to search:");
            string substr = Console.ReadLine();
            Console.WriteLine(TextTool.CountStringOccurrences(text, substr)); 
        }
}
public static class TextTool
{

            public static int CountStringOccurrences(string text, string substr)
            {
                    int count = 0;
                    int i = 0;
                    while ((i = text.IndexOf(substr, i)) != -1)
            {
                    i ++;
                    count++;
            }
                    return count;
            }
}
