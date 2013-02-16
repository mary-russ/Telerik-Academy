using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.*/

            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(year) ? "{0} is leap." : "{0} is not leap.", year);

        }
    }
}
