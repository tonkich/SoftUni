using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Content-type:text/html\r\n\r\n");
            Console.WriteLine("<form action=\"Calculator.exe\" method=\"post\">");
            Console.WriteLine("<input type=\"text\" name=\"operandOne\"/>");
            Console.WriteLine("<input type=\"text\" name=\"sign\"/>");
            Console.WriteLine("<input type=\"text\" name=\"operandTwo\"/>");
            Console.WriteLine("<input type=\"submit\"value=\"Calculate\"/>");
            Console.WriteLine("</form>");
            string postContent = Console.ReadLine();
            if (postContent != null)
            {
                string[] variables = postContent.Split(new char[] { '&', '=' }, StringSplitOptions.RemoveEmptyEntries);
                double firstOperand = double.Parse(variables[1]);
                string operation = variables[3];
                double secondOperand = double.Parse(variables[5]);
                double result;
                switch (operation)
                {
                    case "%2B": // + sign
                        result = firstOperand + secondOperand;
                        Console.WriteLine("<p>");
                        Console.WriteLine($"Result: {result}" );
                        Console.WriteLine("</p>");
                        break;
                    case "-":
                        result = firstOperand - secondOperand;
                        Console.WriteLine("<p>");
                        Console.WriteLine($"Result: {result}");
                        Console.WriteLine("</p>");
                        break;
                    case "*": // * sign
                        result = firstOperand * secondOperand;
                        Console.WriteLine("<p>");
                        Console.WriteLine($"Result: {result}");
                        Console.WriteLine("</p>");
                        break;
                    case "%2F": // / sign
                        result = firstOperand / secondOperand;
                        Console.WriteLine("<p>");
                        Console.WriteLine($"Result: {result}");
                        Console.WriteLine("</p>");
                        break;
                    default:
                        Console.WriteLine("<p>");
                        Console.WriteLine("Invalid sign!");
                        Console.WriteLine("</p>");
                        break;
                }
            }
        }
    }
}
