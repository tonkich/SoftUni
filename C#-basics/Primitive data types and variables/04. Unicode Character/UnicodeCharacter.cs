using System;
class UnicodeCharacter
{
    static void Main()
    {
        int code = 42;
        Console.WriteLine("The hexadecimal representation of code 42 is: {0:X}", code);
        char symbol = '\u0042';
        Console.WriteLine("The symbol is: {0}", symbol);
    }
}