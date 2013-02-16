using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.ReverseSentence
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            /*Write a program that reverses the words in given sentence.
	          Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".*/

            string sentence = "C# is not C++, not PHP and not Delphi!";
            char punctuation = sentence[sentence.Length - 1];
            string s =  sentence.TrimEnd(new char[]{'.', '!', '?'});
            string[] words = s.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    Console.Write(words[i] + " ");
                }
                
                else if (i == 0)
                {
                  Console.Write(words[i] + punctuation);  
                }
            }
            Console.WriteLine();
        }
    }
}
