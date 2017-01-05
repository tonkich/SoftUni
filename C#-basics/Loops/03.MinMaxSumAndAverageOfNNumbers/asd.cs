using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAndAverageOfNNumbers
{
class asd
{
      static void Main(string[] args)
      {
         Console.Write("Enter the total numbers:");
         int n = Convert.ToInt32(Console.ReadLine());
         int[] arrNumbers = new int[n];
 
         for (int i = 0; i < n; i++)
         {
            Console.Write("Enter {0} No.: ", i + 1);
            arrNumbers[i] = Convert.ToInt32(Console.ReadLine());
         }
 
         int min = arrNumbers[0];
         int max = arrNumbers[0];
         int sum = 0;
         double average = 0;
         for (int i = 0; i < n; i++)
         {
            sum += arrNumbers[i];
            if (min > arrNumbers[i])
               min = arrNumbers[i];
            if (max < arrNumbers[i])
               max = arrNumbers[i];
         }
         average = (double)sum / n;
 
         Console.WriteLine();
         Console.WriteLine("Sum\t: {0}", sum);
         Console.WriteLine("Average\t: {0,2:n}", average);
         Console.WriteLine("Min\t: {0}", min);
         Console.WriteLine("Max\t: {0}", max);
      }      
        }
}
