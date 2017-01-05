using System;
class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter Age:");
        string Age = Console.ReadLine();
        int ma = int.Parse(Age);
        DateTime today = DateTime.Now;
        DateTime future = today.AddYears(10);
        DateTime futurYear = future.AddYears(ma); 
        int fa = futurYear.Year - today.Year;
        Console.WriteLine("\nIn 10 years you will be:");
        Console.WriteLine(fa);
    }
}