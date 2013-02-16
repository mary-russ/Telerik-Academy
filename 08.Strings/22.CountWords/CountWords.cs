using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22.CountWords
{
    class CountWords
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a string from the console and lists all different words in the 
             string along with information how many times each word is found.*/

            string str = "shdhjf sdjkfkk fjfjtk dhtjyuih shdhjf sdjkfkk sdjkfkk dhtjyuih";
            var strings = str.Split(' ').GroupBy(s => s).Select(g => new { word = g.Key, count = g.Count() });
            foreach (var s in strings)
            {
                Console.WriteLine("{0} -> {1} times", s.word, s.count);
            }
        }
    }
}
