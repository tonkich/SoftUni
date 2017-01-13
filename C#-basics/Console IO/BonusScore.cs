using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Score
{
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter score: ");
            int a = int.Parse(Console.ReadLine());
            int b = 10 * a;
            int c = 100 * a;
            int d = 1000 * a;
            if (a >= 1 && 3 >= a)
            { Console.WriteLine("Your score is: {0}", b); }
            else if (a >= 4 && 6 >= a)
            { Console.WriteLine("Your score is: {0}", c); }
            else if (a >= 7 && 9 >= a)
            { Console.WriteLine("Your score is: {0}", d); }
            else  
            { Console.WriteLine("Invalid score"); }
        }
}
