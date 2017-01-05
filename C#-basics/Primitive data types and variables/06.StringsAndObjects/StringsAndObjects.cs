using System;
class StringsAndObjects
{
        static void Main()
        {
            string s1 = "Hello";
            string s2 = "World!";
            object concat = s1 + " " + s2;
            string s3 = (string)concat;
            Console.WriteLine(s3);
        }
}
