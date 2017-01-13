using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class PrimeNum
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int theNum = int.Parse(Console.ReadLine());
        if (theNum < 3) 
        {
            if (theNum == 2)
            {
                Console.WriteLine("{0} is a prime!", theNum);
            }
            else
            {
                Console.WriteLine("{0} is not a prime", theNum);
            }
        }
        else
        {
            if (theNum % 2 == 0)
            {
                Console.WriteLine("{0} is not a prime", theNum);
            }
            else
            {
                int div;
                  for (div = 3; theNum % div != 0; div += 2);
                if ((div == theNum) && (100 >= theNum))
                {
                    Console.WriteLine("{0} is a prime!", theNum);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime or is more than 100", theNum);
                }
            }
        }
        Console.ReadLine();
        }
}
    

    
            
