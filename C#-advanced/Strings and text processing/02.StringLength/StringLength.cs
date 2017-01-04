using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StringLength
{
        static void Main()
        {
            const int MaxLength = 20;
            string name = Console.ReadLine();
            if (name.Length > MaxLength)
            {
                name = name.Substring(0, MaxLength);
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine(name.PadRight(20, '*'));
            }
        }
}
    
