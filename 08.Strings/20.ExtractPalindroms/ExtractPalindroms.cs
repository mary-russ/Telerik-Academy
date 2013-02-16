using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20.ExtractPalindroms
{
    class ExtractPalindroms
    {
        public static bool isPalindrome(string word)
        {
            bool isPalindrome = true;

            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                }
            }
            return isPalindrome;
        }

        static void Main(string[] args)
        {
            /*Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".*/

            string text = "A palindrome ala is a word, phrase, abba, number, or other sequence of exe, units" + 
                "that may be read the nun same way in either direction, with general allowances for pop adjustments" + 
                "to punctuation and word dividers.Composing ala literature in palindromes is an example of lamal constrained writing.";
            string[] words = text.Split(' ', ',');

            foreach (var item in words)
            {
                if (isPalindrome(item))
                    Console.WriteLine(item);
            }

        }
    }
}
