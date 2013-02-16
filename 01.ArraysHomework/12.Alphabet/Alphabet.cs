using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Alphabet
{
    static void Main()
    {
        /*Write a program that creates an array containing all letters from the alphabet (A-Z).
         Read a word from the console and print the index of each of its letters in the array. */

        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(i + 65);
            Console.Write(alphabet[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        word = word.ToUpper();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine("the index of the letter {0} in the English alphabet is {1}", word[i], j + 1);
                }
            }
        }       
    }
}

