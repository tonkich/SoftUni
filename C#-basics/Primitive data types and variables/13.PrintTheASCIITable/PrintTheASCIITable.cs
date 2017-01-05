using System;
class PrintTheASCIITable
{
        static void Main(string[] args)
        {
            for (int character = 0; character < 127; character++)
            {
                char symbol = (char)character;
                Console.WriteLine("{0} -> {1}", character, symbol);
            }
        }
}
