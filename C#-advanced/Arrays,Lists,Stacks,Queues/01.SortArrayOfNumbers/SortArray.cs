using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SortArray
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ')
        .Select(int.Parse).ToArray();
        Array.Sort(arr);
        foreach (int i in arr) Console.Write(i + " ");
        Console.WriteLine();
    }
}
