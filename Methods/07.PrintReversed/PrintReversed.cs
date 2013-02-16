using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.PrintReversed
{
    class PrintReversed
    {
        static void PrintNumber(decimal num)
        {
            string str = num.ToString();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }

        static void Main()
        {
            /*Write a method that reverses the digits of given decimal number. Example: 256 => 652 */
         
            decimal n = 25673482986356787;
            PrintNumber(n);
            Console.WriteLine();
        }
    }
}


