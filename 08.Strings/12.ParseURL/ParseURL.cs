using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            /*Write a program that parses an URL address given in the format:
            [protocol]://[server]/[resource]
		    and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php 
            the following information should be extracted:
		    [protocol] = "http"
		    [server] = "www.devbg.org"
		    [resource] = "/forum/index.php" */

            //Console.Write("Enter an URL: ");
            //string inputURL = Console.ReadLine();
            string inputURL = "http://www.devbg.org/forum/index.php ";
           
                int index = inputURL.IndexOf("://");
                Console.WriteLine("[protocol] = \"{0}\"", inputURL.Substring(0, index));
                int server = inputURL.IndexOf("/", index + 3);
                Console.WriteLine("[server] = \"{0}\"", inputURL.Substring(index + 3, server - index - 3));
                Console.WriteLine("[resource] = \"{0}\"", inputURL.Substring(server));
                Console.WriteLine();
        }
    }
}
