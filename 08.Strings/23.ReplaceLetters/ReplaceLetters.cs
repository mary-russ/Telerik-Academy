using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _23.ReplaceLetters
{
    class ReplaceLetters
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a string from the console and replaces all series of consecutive 
             identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".*/

            //Console.Write("Enter a string: ");
            string input = "aaaaabbbbbcdddeeeedssaa";
            //string input = Console.ReadLine();
            StringBuilder letters = new StringBuilder();
            bool newLetter = true;
            letters.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    newLetter = false;
                }
                else
                {
                    newLetter = true;
                }
                if (newLetter)
                {
                    letters.Append(input[i]);
                }
            }
            Console.WriteLine("{0} -> {1}", input, letters.ToString());

        }
    }
}
