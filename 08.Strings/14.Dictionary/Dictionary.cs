using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            /*A dictionary is stored as a sequence of text lines containing words and their explanations.
             Write a program that enters a word and translates it by using the dictionary. */

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string[] keyWords =  { ".NET", "CLR", "namespace", "string", "object" };
            string[] explanation = 
            {
                "platform for applications from Microsoft",
                "managed execution environment for .NET",
                "hierarchical organization of classes",
                "represents text as a series of Unicode characters",
                "the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy"
            };
            for (int i = 0; i < keyWords.Length; i++)
            {
                dictionary.Add(keyWords[i].ToUpper(), explanation[i]);
            }
            Console.WriteLine("This dictionary consist of the words: .NET, CLR, namespace, string and object. Enter one of this words for explanation: ");
            string inputWord = Console.ReadLine();
            try
            {
                Console.WriteLine("{0} - {1}", inputWord, dictionary[inputWord.ToUpper()]);
            }
            catch (KeyNotFoundException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
}
