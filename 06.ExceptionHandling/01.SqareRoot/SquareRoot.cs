using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.SqareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            /*Write a program that reads an integer number and calculates and prints its square root.
             If the number is invalid or negative, print "Invalid number". 
             In all cases finally print "Good bye". Use try-catch-finally */

            Console.Write("Enter a positive number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("The number must be positive!");
                }
                else
                {
                    double sqRoot = Math.Sqrt(number);
                    Console.WriteLine("Square root of {0} is {1}.", number, sqRoot);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
           
            finally
            {
                Console.WriteLine("Good Bye!!!");
            }
        }
    }
}
