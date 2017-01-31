using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
class replaceAtag
{
        static void Main()
        {

            string html = @"<ul>
                    <li>
                    <a href=http://softuni.bg>SoftUni</a>
                    </li>
                    </ul>";
            string pattern = "<a(\\shref=.+)>(.+)<\\/a>";

            Console.WriteLine(Regex.Replace(html, pattern, @"[URL href=$1]$2[/URL]"));
        }
}
