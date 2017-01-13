using System;
class Program
{
        static void Main()
        {
            string s1 = "The \"use\" of quotations causes difficulties.";
            string s2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("First variant: " + s1);
            Console.WriteLine("Second variant: " + s2);
        }
}
