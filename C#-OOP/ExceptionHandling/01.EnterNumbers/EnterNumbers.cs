using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        public static int? ReadNumber(ref int start, ref int end)
        {
            Console.Write("Enter an integer [{0}..{1}] inclusive: ", start, end);
            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n < start || n > end) throw new ArgumentOutOfRangeException();
                if (n == end)
                {
                    end = n - 1;
                    return n;
                }

                if (n + 1 <= end)
                {
                    start = n + 1;
                    return n;
                }

                return null;
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
            catch (ArgumentNullException)
            {
                return null;
            }
            catch (FormatException)
            {
                return null;
            }
            catch (OverflowException)
            {
                return null;
            }
        }

        public static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int count = 0;
            List<int> numList = new List<int>();

            while (count < 10)
            {
                int? n = ReadNumber(ref start, ref end);

                if (n.HasValue)
                {
                    count++;
                    numList.Add((int)n);
                }

                if (start > end)
                {
                    Console.WriteLine("No more integers to choose from. Range length is zero.");
                    break;
                }
            }

            Console.WriteLine("Finnished. {0} integers have been chosen", count);
            string implode = string.Join(", ", numList.ToArray());
            Console.WriteLine(implode);
        }
    }
}
