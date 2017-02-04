using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddCake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Content-type: text/html\r\n");
            string htmlContent = File.ReadAllText("C:/xampp/cgi-bin/AddCake.html");
            Console.WriteLine(htmlContent);
            string postContent = Console.ReadLine();
            if (postContent!=null)
            {
                string[] variables = postContent.Split('&');
                string name = variables[0].Split('=')[1];
                string price = variables[1].Split('=')[1];
                File.AppendAllText("database.csv", $"{name},{price} {Environment.NewLine}");
            }
        }
    }
}
