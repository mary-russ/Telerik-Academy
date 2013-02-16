using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Upcase
{
    class Upcase
    {
        static void ChangeCase(string text, string openTag, string closeTag)
        {
            int openLen = openTag.Length;
            int closeLen = closeTag.Length;
            int startIndex = 0;
            int endIndex = 0;
            string temp = "";

            while (text.IndexOf(openTag) > 0 & text.IndexOf(closeTag) > 0)
            {
                startIndex = text.IndexOf(openTag);
                endIndex = text.IndexOf(closeTag);
                temp = text.Substring(startIndex + openLen, endIndex - (startIndex + openLen));             
                text = text.Replace(temp, temp.ToUpper());
                text = text.Remove(text.IndexOf(openTag), openLen);
                text = text.Remove(text.IndexOf(closeTag), closeLen);
            }
            Console.WriteLine(text);
        }


        static void Main(string[] args)
        {
            /*You are given a text. Write a program that changes the text in all regions surrounded by the tags
             <upcase> and </upcase> to uppercase. The tags cannot be nested. */

            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            ChangeCase(text, openTag, closeTag);
        }
    }
}
