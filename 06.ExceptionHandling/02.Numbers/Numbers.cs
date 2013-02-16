using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Numbers
{
    class Numbers
    {
        static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int number;

            try
            {
                number = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input! Should be number!");
                throw new ApplicationException("ReadNumber didn't receive number as expected!");
            }

            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException("The number is not within specified bounds!!");
            }

            return number;
        }
        static void Main(string[] args)
        {
            /*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end].
             If an invalid number or non-number text is entered, the method should throw an exception. 
             Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100 */

             int[] numbers = new int[10];
            Console.WriteLine("Enter 10 growing numbers between 1 and 100");
            numbers[0] = ReadNumber(1, 100);
            for (int i = 1; i < 10; i++)
            {
                try
                {
                    numbers[i] = ReadNumber(numbers[i - 1], 100);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Each number must be greater than previous!");
                    i--;
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine(ex.Message);
                    i--;
                }
            }
        }
    }
}
