using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.LastDigit
{
    class LastDigit
    {
        static void GetDigitName(int digit)
        {
            string[] digitName = new string[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            Console.WriteLine(digitName[digit]);
        }
   
        static void Main()
        {
            /*Write a method that returns the last digit of given integer as an English word. 
             Examples: 512 => "two", 1024 => "four", 12309 => "nine".*/

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int lastD = number % 10;
            GetDigitName(lastD);
        }
    }
}
