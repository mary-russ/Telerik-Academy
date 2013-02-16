using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            /*Write a program that prints to the console which day of the week is today. Use System.DateTime */

            DateTime today = new DateTime();
            today = DateTime.Now;
            Console.WriteLine("Today is {0}.", today.DayOfWeek);
        }
    }
}
