using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, Dictionary<string, int>> venues = new Dictionary<string, Dictionary<string, int>>();
            string[] singerInfo = Console.ReadLine().Split();
            while (singerInfo[0] != "End")
            {
                if (singerInfo.Length < 4)
                {
                    singerInfo = Console.ReadLine().Split();
                    continue;
                }
                StringBuilder singerName = new StringBuilder();
                int k = 0;
                for (int i = 0; i < singerInfo.Length; i++)
                {
                    if (!singerInfo[i].StartsWith("@"))
                    {
                        singerName.Append(singerInfo[i] + " ");
                    }
                    else
                    {
                        k = i;
                        break;
                    }
                }
                StringBuilder singerVenue = new StringBuilder();
                for (int i = k; i < singerInfo.Length; i++)
                {
                    if (singerInfo[i].StartsWith("@"))
                    {
                        singerVenue.Append(singerInfo[i] + " ");
                        for (int j = i + 1; j < singerInfo.Length; j++)
                        {
                            if (Regex.IsMatch(singerInfo[j], @"^\d+$"))
                            {
                                break;
                            }
                            else
                            {
                                singerVenue.Append(singerInfo[j] + " ");
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                int OveralTicketsPrice;
                try
                {
                     OveralTicketsPrice = int.Parse(singerInfo[singerInfo.Length - 2]) * int.Parse(singerInfo[singerInfo.Length - 1]);

                }
                catch (Exception)
                {
                    continue;
                }
                
                if (!venues.ContainsKey(singerVenue.ToString()))
                {
                    venues.Add(singerVenue.ToString(), new Dictionary<string, int>());
                    if (venues[singerVenue.ToString()].ContainsKey(singerName.ToString()))
                    {
                        venues[singerVenue.ToString()][singerName.ToString()] += OveralTicketsPrice;
                    }
                    else
                    {
                        venues[singerVenue.ToString()].Add(singerName.ToString(), OveralTicketsPrice);
                    }

                }
                else
                {
                    if (venues[singerVenue.ToString()].ContainsKey(singerName.ToString()))
                    {
                        venues[singerVenue.ToString()][singerName.ToString()] += OveralTicketsPrice;
                    }
                    else
                    {
                        venues[singerVenue.ToString()].Add(singerName.ToString(), OveralTicketsPrice);
                    }
                }
                singerInfo = Console.ReadLine().Split();
            }



            foreach (KeyValuePair<string, Dictionary<string, int>> venue in venues)
            {
                sb.AppendLine($"{venue.Key.TrimStart('@').TrimEnd()}");
                var orderedVenues = venue.Value.OrderByDescending(v => v.Value);
                foreach (KeyValuePair<string, int> singer in orderedVenues)
                {
                    sb.AppendLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
            Console.WriteLine(sb.ToString());

        }
    }
}