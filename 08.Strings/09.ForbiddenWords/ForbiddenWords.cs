using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            /*We are given a string containing a list of forbidden words and a text containing some of these words.
             Write a program that replaces the forbidden words with asterisks. */

            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP, CLR, Microsoft";
            char[] comma = { ',' };
            foreach (string s in words.Split(comma, StringSplitOptions.RemoveEmptyEntries))
            {
                text = text.Replace(s.Trim(), new string('*', s.Length));
            }
            Console.WriteLine(text);
            Console.WriteLine();
        }
    }
}
