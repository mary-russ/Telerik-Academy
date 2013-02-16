using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            /*Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> 
             with corresponding tags [URL=…]…/URL]. */

            string htmlText = @"<p>Please visit <a href=""http://academy.telerik. com""> our site </a> to choose a training course. Also visit <a href=""www.devbg.org""> our forum</a> to discuss the courses.</p>";
            string replace1 = "[URL";
            string replace2 = "]";
            string replace3 = "[/URL]";
            string replaced = "";
            for (int i = 1; i < htmlText.Length -2; i++)
            {
                if (htmlText[i] == '<')
                {
                    if (htmlText[i + 1] == 'a')
                    {
                        string sub1 = htmlText.Substring(i, 7);
                       htmlText = htmlText.Replace(sub1, replace1);
                    }
                    else if (htmlText[i + 1] == '/' && htmlText[i + 2] == 'a')
                    {
                        string sub2 = htmlText.Substring(i, 4);
                        htmlText = htmlText.Replace(sub2, replace3);
                    }
                }
                if (htmlText[i] == '>' && htmlText[i - 1] != 'p')
                {
                    string sub3 = htmlText.Substring(i, 1);
                    htmlText =  htmlText.Remove(i, 1);
                    htmlText = htmlText.Insert(i, replace2);
                }
            }
            Console.WriteLine(htmlText);
        }
    }
}
