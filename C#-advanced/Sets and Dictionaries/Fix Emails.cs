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
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
            {
                string email = Console.ReadLine();
                if (!string.IsNullOrEmpty(email))
                {
                    if (!emails.ContainsKey(name) && email.Length > 3 && email.Contains('@') && email.Substring(email.Length - 2, 2) != "us" && email.Substring(email.Length - 2, 2) != "uk")
                    {
                        emails.Add(name, email);
                    }
                    while (name != "stop")
                    {
                        name = Console.ReadLine();
                        if (name == "stop")
                        {
                            foreach (KeyValuePair<string, string> item in emails)
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                            return;
                        }
                        email = Console.ReadLine();
                        if (!emails.ContainsKey(name) && email.Length > 3 && email.Contains('@') && email.Substring(email.Length - 2, 2) != "us" && email.Substring(email.Length - 2, 2) != "uk")
                        {
                            emails.Add(name, email);
                        }
                    }
                }
            }
        }
    }
}