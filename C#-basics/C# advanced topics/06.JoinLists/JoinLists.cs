using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class JoinLists
{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first list of integers with space between them: ");
            string numbersLine1 = Console.ReadLine();
            string[] numbers1 = numbersLine1.Split(new char[] { ' ' });
            int[] list1 = Array.ConvertAll(numbers1, int.Parse);
            Console.WriteLine("Enter second list of integers with space between them: ");
            string numbersLine2 = Console.ReadLine();
            string[] numbers2 = numbersLine2.Split(new char[] { ' ' });
            int[] list2 = Array.ConvertAll(numbers2, int.Parse);
            IEnumerable<int> union = list1.Union(list2);
            union = union.OrderBy(c => c).ToArray();
            foreach (int num in union)
            {
                Console.Write("{0} ", num);
            }
         }
}
