using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

namespace _17.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
             and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.Write("Enter date and time(day.month.year hour:minute:second): ");
            DateTime input = DateTime.Parse(Console.ReadLine());
            DateTime result = input.AddHours(6.5);
           // Console.WriteLine("Input day and time: {0}", input);
            Console.WriteLine("After 6 hours and 30 minutes: {0}", result);
            Console.WriteLine("Day of week in Bulgarian: {0}", DateTimeFormatInfo.CurrentInfo.GetDayName(result.DayOfWeek));

        }
    }
}
