using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.SumString
{
    class SumString
    {
        static void Main(string[] args)
        {
            /*You are given a sequence of positive integer values written into a string, separated by spaces.
             Write a function that reads these values from given string and calculates their sum. Example:
		      string = "43 68 9 23 318" => result = 461 */

            string inputStr = "43 68 9 23 318";
            string[] container = inputStr.Split(' ');
            foreach (var item in container)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int len = container.Length;
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += int.Parse(container[i].Trim());
            }
            Console.WriteLine("The sum is: " + sum);



        }
    }
}
