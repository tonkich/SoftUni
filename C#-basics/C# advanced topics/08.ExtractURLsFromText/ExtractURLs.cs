using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractURLsFromText
{
    class ExtractURLs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string containing URLs beggining with http:// or www. : ");
            string rawString = Console.ReadLine();
            var links = rawString.Split("\t\n ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www.") || s.StartsWith("https://"));
            foreach (string s in links)
                MessageBox.Show(s);
        }
    }
}
