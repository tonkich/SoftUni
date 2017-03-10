using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowseCakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Content-type: text/html\r\n");
            string htmlContent = File.ReadAllText("C:/xampp/cgi-bin/BrowseCakes.html");
            Console.WriteLine(htmlContent);
            if (Environment.GetEnvironmentVariable("QUERY_STRING")!=null)
            {
                string getContent = Environment.GetEnvironmentVariable("QUERY_STRING");
                if (getContent.Length>0)
                {
                    string cakeName = getContent.Split('=')[1];
                    string[] databaseContent = File.ReadAllLines("C:/xampp/cgi-bin/database.csv");
                    var filtered = databaseContent.Where(s => s.Contains(cakeName));
                    foreach (string s in filtered)
                    {
                        Console.WriteLine("<p>");
                        Console.WriteLine(s);
                        Console.WriteLine("</p>");
                    }

                }

            }
        }
    }
}
