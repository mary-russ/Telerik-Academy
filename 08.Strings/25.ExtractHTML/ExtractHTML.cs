using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _25.ExtractHTML
{
    class ExtractHTML
    {
        static void Main(string[] args)
        {
            /*Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. */

            string str = "<html>" + 
                          "<head><title>News</title></head>" +
                          "<body><p><a href=\"http://academy.telerik.com\">Telerik " + 
                            "Academy</a>aims to provide free real-world practical " +
                            "training for young people who want to turn into " +
                            "skillful .NET software engineers.</p></body>" +
                        "</html>";
            bool isBetween = false;
            StringBuilder text = new StringBuilder();
            StringBuilder tag = new StringBuilder();
            string title = "";
            foreach (char s in str)
            {
                if (s == '<')
                {
                    isBetween = true;
                }
                if (s == '>')
                {
                    isBetween = false;
                    tag.Append(s);
                    if (tag.ToString().ToUpper() == "</title>".ToUpper())
                    {
                        title = text.ToString();
                        text.Clear();
                    }
                    if (tag.ToString().ToUpper() == "</a>".ToUpper())
                    {
                        text.Append(" ");
                    }
                    tag.Clear();
                    continue;
                }
                if (isBetween == false)
                {
                    text.Append(s);
                }
                else
                {
                    tag.Append(s);
                }
            }
            Console.WriteLine("Title -> {0}", title);
            Console.WriteLine("Body -> {0}", text.ToString());

        }
    }
}
