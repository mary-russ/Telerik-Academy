using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace _04.FileFromInternet
{
    class FileFromInternet
    {
        static void Main(string[] args)
        {
            /*Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
             and stores it the current directory. Find in Google how to download files in C#. 
             Be sure to catch all exceptions and to free any used resources in the finally block.*/

            WebClient myWeb = new WebClient();
            string url = "http://www.devbg.org/img/Logo-BASD.jpg";
            string storagePath = @Environment.CurrentDirectory + @"\Logo-BASD.jpg";
            try
            {
                myWeb.DownloadFile(url, storagePath);
                Console.WriteLine("Download successful!");
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
 
            }
            catch (NotSupportedException notSupportedEx)
            {
                Console.WriteLine(notSupportedEx.Message);
            }
            finally
            {
                myWeb.Dispose();
            }
           
       }
    }
}
