using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
class Beer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        try
        {
            Console.WriteLine("Please, enter time: ");
            string date = Console.ReadLine();
            DateTime time = DateTime.Parse(date);
            time.ToString("hh:mm tt");
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            if (time >= startTime || time < endTime)
            {
                Console.WriteLine("Beer time");
            }
            else
            {
                Console.WriteLine("Non-beer time");
            }
        }
        catch (FormatException)
        {

            Console.WriteLine("Invalid time!");
            Main();
        }
    }
}