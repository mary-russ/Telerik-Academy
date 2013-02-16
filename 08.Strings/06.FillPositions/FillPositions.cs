using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.FillPositions
{
    class FillPositions
    {
        static void Main(string[] args)
        {
            /*Write a program that reads from the console a string of maximum 20 characters. 
             If the length of the string is less than 20, the rest of the characters should be filled with '*'.
             Print the result string into the console.*/

            Console.Write("Enter a string up to 20 characters: ");
            string input = Console.ReadLine();
            if (input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));                  
            }
        }
    }
}
