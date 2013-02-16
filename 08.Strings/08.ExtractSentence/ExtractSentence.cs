using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.ExtractSentence
{
    class ExtractSentence
    {
        static void Main(string[] args)
        {
            /*Write a program that extracts from a given text all sentences containing given word.
             Consider that the sentences are separated by "." and the words – by non-letter symbols.*/

            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
            string[] sentences = text.Split('.');

            foreach (string s in sentences)
            {
                string[] words = s.Split(' ');

                if (words.Contains("in"))
                {
                    Console.WriteLine(s);
                }
            }

        }
    }
}
