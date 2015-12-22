using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double m = Math.Sqrt(n);
                Console.WriteLine(m);
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number should be positive!");
            }

            finally
            {
                Console.WriteLine("Good bye!");
            }
        
        }
    }
}
