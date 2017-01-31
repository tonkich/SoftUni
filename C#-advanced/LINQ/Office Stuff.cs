using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> companies = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] companyDelivery = Console.ReadLine().Split(new char[] { ' ', '|', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string companyName = companyDelivery[0];
                string itemToDeliver = companyDelivery[2];
                int amountOfItems = int.Parse(companyDelivery[1]);
                if (companies.ContainsKey(companyName))
                {
                    if (companies[companyName].ContainsKey(itemToDeliver))
                    {
                        companies[companyName][itemToDeliver] += amountOfItems;
                    }
                    else
                    {
                        companies[companyName].Add(itemToDeliver, amountOfItems);
                    }
                }
                else
                {
                    companies.Add(companyName, new Dictionary<string, int>());
                    companies[companyName].Add(itemToDeliver, amountOfItems);
                }
            }
            StringBuilder result = new StringBuilder();
            var orderedCompanies = companies.OrderBy(kvp => kvp.Key);
            foreach (KeyValuePair<string, Dictionary<string, int>> kvp in orderedCompanies)
            {
                result.Append($"{kvp.Key}: ");
                foreach (KeyValuePair<string, int> kvptwo in kvp.Value)
                {
                    result.Append($"{kvptwo.Key}-{kvptwo.Value}, ");
                }
                result.Length -= 2;
                result.AppendLine();
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}