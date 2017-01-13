using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lice
{
    class Program
    {

        static void Main(string[] args)
        {
            Liststring[] students = new Liststring[]();
            string input = Console.ReadLine();
            while (input!=END)
            {
                string[] studentDetails = input.Split();
                students.Add(studentDetails);
                input = Console.ReadLine();
            }
            students.Where(x = x.Skip(2).Count(y = int.Parse(y) = 3) = 2)
                    .ToList()
                    .ForEach(x = Console.WriteLine(string.Join( , x[0], x[1])));
        }
    }
}
