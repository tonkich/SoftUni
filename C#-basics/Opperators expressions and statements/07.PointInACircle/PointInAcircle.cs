using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInACircle
{
    class PointInAcircle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the center of the circle : ");
            Console.Write("Enter x coordinate of the centre : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y coordinate of the centre : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Point : ");
            Console.Write("Please Enter x coordinate of the point : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter y coordinate of the point : ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            int check = Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
                if (check < r)
                { 
                    Console.WriteLine("Inside the Circle"); 
                }
                    else if (check == r)
                { 
                    Console.WriteLine("On the Circle"); 
                }
                    else
                { 
                    Console.WriteLine("Outside the Circle"); 
                }
        }
    }
}
