using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

                Dictionary<string, int> dict = new Dictionary<string, int>();
                string resource = null;
                while (resource != "stop")
                {
                    resource = Console.ReadLine();
                    if (resource == "stop")
                    {
                        break;
                    }
                    int quantity = int.Parse(Console.ReadLine());
                    if (!dict.ContainsKey(resource))
                    {
                        dict.Add(resource, quantity);
                    }
                    else
                    {
                        dict[resource] += quantity;
                    }
                }
                
                foreach (KeyValuePair<string, int> kvp in dict)
                {
                    Console.WriteLine($"{ kvp.Key} -> {kvp.Value} ");
                }
            }
        }
}
