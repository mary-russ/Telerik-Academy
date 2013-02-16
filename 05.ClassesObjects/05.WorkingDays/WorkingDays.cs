using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.WorkingDays
{
    class WorkingDays
    {
        static int CalculateWorkingDays(DateTime today, DateTime final)
        {
            List<DateTime> holidays = new List<DateTime>() { new DateTime(2013, 01, 01), new DateTime(2013, 03, 03), 
                new DateTime(2013, 05, 01), new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), new DateTime(2013, 05, 05), 
                new DateTime(2013, 05, 06),new DateTime(2013, 05, 24), new DateTime(2013, 09, 06), new DateTime(2013, 09, 22),
                new DateTime(2013, 12, 24), new DateTime(2013, 12, 25), new DateTime(2013, 12, 26),};
  
            int workdays = 0;
            for (DateTime i = today; i <= final; i = i.AddDays(1))
            {              
                if (i.DayOfWeek.CompareTo(DayOfWeek.Saturday) != 0 || i.DayOfWeek.CompareTo(DayOfWeek.Saturday) != 0)
                {
                    workdays++;
                    for (int j = 0; j < holidays.Count; j++)
                    {
                        if (i.CompareTo(holidays[j]) == 0)
                        {
                            if (holidays[j].DayOfWeek == DayOfWeek.Saturday || holidays[j].DayOfWeek == DayOfWeek.Sunday)
                            {
                                workdays--;
                            }
                        }
                    }
                }
            }
            return workdays;
        }

        static void Main(string[] args)
        {
            /*Write a method that calculates the number of workdays between today and given date, passed as parameter. 
             Consider that workdays are all days from Monday to Friday except a fixed list of public holidays 
             specified preliminary as array. */

            DateTime today = DateTime.Today;
            Console.Write("Enter a final date in the following format: YYY-MM-DD: ");
            DateTime finalDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("There are {0} workdays between {1} and {2}.", CalculateWorkingDays(today, finalDate), today, finalDate);

        }
    }
}
