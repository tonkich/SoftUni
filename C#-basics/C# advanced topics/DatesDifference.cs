using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DatesDifference
{
    static TimeSpan DaysDifference(DateTime startDate, DateTime endDate)
    {
        TimeSpan days = endDate - startDate;

        return days;
    }

    static void Main()
    {
        CultureInfo bgBG = new CultureInfo("bg-BG");

        try
        {
            Console.Write("Enter first date in d.MM.yyyy format: ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", bgBG);
            Console.Write("Enter second date in d.MM.yyyy format: ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", bgBG);

            Console.WriteLine("Days between: "+ DaysDifference(startDate, endDate).Days);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date! Dates must be in format dd.MM.yyyy.");
        }
    }
}