using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> logsByUser = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input!="end")
            {
                
                string[] logInfo = input.Split();
                string[] IPinfo = logInfo[0].Split('=');
                string IP = IPinfo[1];
                string[] userInfo = logInfo[2].Split('=');
                string user = userInfo[1];
                if (!logsByUser.ContainsKey(user))
                {
                    logsByUser.Add(user, new Dictionary<string, int>());
                    logsByUser[user].Add(IP, 0);
                }
                else if (!logsByUser[user].ContainsKey(IP))
                {
                    logsByUser[user].Add(IP, 0);
                }
                logsByUser[user][IP]++;
                input = Console.ReadLine();
            }
            foreach (var outerPair in logsByUser)
            {
                Console.WriteLine("{0}: ",outerPair.Key);
                Console.WriteLine("{0}. ", string.Join(", ",outerPair.
                    Value.
                    Select(kv=>kv.Key+" => " +kv.Value)));
                
            }
        }
    }
}
