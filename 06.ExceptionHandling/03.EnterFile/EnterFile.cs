using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _03.EnterFile
{
    class EnterFile
    {
        static void Main(string[] args)
        {
            /*Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
             reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
             Be sure to catch all possible exceptions and print user-friendly error messages.*/

            string path = @"C:\WINDOWS\win.ini";
            try
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path {0} is to long!", path);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The dir {0} was NOT Found!", path);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You do NOT have authorization to open this file!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The searched file was NOT found!");
            }

        }
    }
}
