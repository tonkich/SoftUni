using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "search")
            {
                string[] splittedInput = input.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = splittedInput[0];
                string phoneNumber = splittedInput[1];
                if (dict.ContainsKey(name))
                {
                    dict[name] = phoneNumber;
                }
                else if (!dict.ContainsKey(name))
                {
                    dict.Add(name, phoneNumber);
                }

                input = Console.ReadLine();
            }
            if (input == "search")
            {
                while (input != "stop")
                {

                    if (!dict.ContainsKey(input)&& input!="search")
                    {
                        sb.Append("Contact ").Append(input).Append(" does not exist.").Append(Environment.NewLine);
                    }
                    if (dict.ContainsKey(input) && input != "search")
                    {
                        sb.Append(input).Append(" -> ").Append(dict[input]).Append(Environment.NewLine);
                    }
                    input = Console.ReadLine();
                }
            }

            string result = sb.ToString().TrimEnd();
            Console.WriteLine(result);
        }
    }
}