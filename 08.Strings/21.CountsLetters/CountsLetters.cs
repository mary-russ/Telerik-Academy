using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21.CountsLetters
{
    class CountsLetters
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a string from the console and prints all different letters 
             in the string along with information how many times each letter is found. */

            //string str = "sfdggt dhdjjuf gjtiyi djrektri";
            Console.Write("Enter a string of letters: ");
            string str = Console.ReadLine();
            var chars = str.ToLower().ToCharArray().GroupBy(c => c);
            foreach (var ch in chars)
            {
                Console.WriteLine("{0} -> {1} times", ch.Key, ch.Count());
            }
        }
    }
}
