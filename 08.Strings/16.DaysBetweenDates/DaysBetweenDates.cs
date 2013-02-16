using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16.DaysBetweenDates
{
    class DaysBetweenDates
    {
        static void Main(string[] args)
        {
            /*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. */

            Console.Write("Enter first date in format day.month.year: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter first date in format day.month.year: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan days = secondDate - firstDate;
            Console.WriteLine("Distance: {0} days", days.Days);
        }
    }
}
