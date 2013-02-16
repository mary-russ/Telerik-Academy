using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _19.ExtractDates
{
    class ExtractDates
    {
        static void Main(string[] args)
        {
            /*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
             Display them in the standard date format for Canada.*/

            string text = "15.08.2013 some text 28.01.2013 some text 05.05.2013 some text";

            string pattern = @"[0-3][0-9]\.[0-1][0-9]\.[0-9]{4}";

            Regex regExpr = new Regex(pattern);

            foreach (var e in regExpr.Matches(text))
            {
                Console.WriteLine(e);
            }
            //string word = "u\\002fu\\0003u\\0008u\\000eu\\0014";
            //Console.WriteLine(word);
            //string[] charsArray = word.Split('u', '\\');
            //foreach (var item in charsArray)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
