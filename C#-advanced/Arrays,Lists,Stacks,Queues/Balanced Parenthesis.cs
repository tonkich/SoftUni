using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] splittedInput = input.ToCharArray();
            int j = splittedInput.Length - 1;
            string message = "NO";
            if (splittedInput.Length % 2 != 0)
            {
                Console.WriteLine(message);
            }
            else
            {
                for (int i = 0; i < (splittedInput.Length - 1)/2; i++, j--)
                { 
                    if (splittedInput[i] == '{' && splittedInput[j] == '}' || splittedInput[i] == '{' && splittedInput[i + 1] == '}' ||
                             splittedInput[j - 1] == '{' && splittedInput[j] == '}')
                    {
                        message = "YES";
                    }
                    else if (splittedInput[i] == '(' && splittedInput[j] == ')' || splittedInput[i] == '(' && splittedInput[i + 1] == ')' ||
                        splittedInput[j - 1] == '(' && splittedInput[j] == ')')
                    {
                        message = "YES";
                    }
                    else if (splittedInput[i] == '[' && splittedInput[j] == ']' || splittedInput[i] == '[' && splittedInput[i + 1] == ']' ||
                        splittedInput[j - 1] == '[' && splittedInput[j] == ']')
                    {
                        message = "YES";
                    }
                    else
                    {
                        message = "NO";
                    }
                }
                Console.WriteLine(message);
            }

        }

    }
}