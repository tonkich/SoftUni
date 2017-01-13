using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class unicodeChar
{
    static void Main()
    {
        string input = Console.ReadLine();
        string unicode = String.Empty;
        foreach (char i in input)
        {
            unicode += "\\u" + ((int)i).ToString("X4");
        }
        Console.WriteLine(unicode);
    }
}