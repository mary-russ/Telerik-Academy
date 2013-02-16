using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _24.PrintSorted
{
    class PrintSorted
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.*/

            //Console.WriteLine("Enter list of words separated by spaces: ");
            //string str = Console.ReadLine();
            string str = "afdgt ajsjjt rhtu seyr bntui fhtj kgkgl ofjkg mvjfj whdjjg";
            var words = str.Split(' ');
            var sorted = words.OrderBy(c=>c);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

        }
    }
}
