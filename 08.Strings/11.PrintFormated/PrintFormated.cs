using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.PrintFormated
{
    class PrintFormated
    {
        static void Main(string[] args)
        {
            /* Write a program that reads a number and prints it as a decimal number, hexadecimal number,
             percentage and in scientific notation. Format the output aligned right in 15 symbols.*/

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("{0,15:D}", number));
            Console.WriteLine(String.Format("{0,15:X4}", number));
            Console.WriteLine(String.Format("{0,15:P}", number));
            Console.WriteLine(String.Format("{0,15:E}", number));
            Console.WriteLine();
        }
    }
}
