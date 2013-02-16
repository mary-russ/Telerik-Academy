using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.ConvertToUnicode
{
    class ConvertToUnicode
    {
        static void Main(string[] args)
        {
            /*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. */

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Your string as a sequence of Unicode characters is: ");
            foreach (char item in input)
            {
                Console.Write("\\u{0:X4}", (int)item); 
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
