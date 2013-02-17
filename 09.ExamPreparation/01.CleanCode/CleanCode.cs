using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.CleanCode
{
    class CleanCode
    {
        static int n;
        static string code;
        static bool inMLComment = false;
        static bool inComment = false;
        static bool inString = false;
        static bool inHardString = false;

        static string Cleaning()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < code.Length; i++)
            {
                if (!inMLComment && !inComment)
                {
                    if (!inString && !inHardString)
                    {
                        if (code[i] == '@' && ((i + 1) < n) && (code[i + 1] == '"'))
                        {
                            inHardString = true;
                            sb.Append(code[i]);
                            i++;
                        }
                        else if (code[i] == '"')
                        {
                            inString = true;
                        }
                        else if ((code[i] == '/') && ((i + 1) < n) && (code[i + 1] == '/') && ((i + 2) < n) && (code[i + 2] != '/'))
                        {
                            inComment = true;
                            i++;
                            continue;
                        }
                        else if ((code[i] == '/') && ((i + 1) < n) && (code[i + 1] == '*'))
                        {
                            inMLComment = true;
                            i++;
                            continue;
                        }
                    }
                    else if (inString)
                    {
                        if (code[i] == '/')
                        {
                            sb.Append(code[i]);
                            i++;
                        }
                        else if (code[i] == '"')
                        {
                            inString = false;
                        }
                    }
                    else if (inHardString)
                    {


                        if (code[i] == '"')
                        {
                            if (((i + 1) < n) && (code[i + 1] == '"'))
                            {
                                sb.Append(code[i]);
                                i++;
                            }
                            else
                            {
                                inHardString = false;
                            }
                        }
                    }
                    sb.Append(code[i]);
                }
                else if (inMLComment)
                {
                    if ((code[i] == '*') && ((i + 1) < n) && (code[i + 1] == '/'))
                    {
                        inMLComment = false;
                        i++;
                    }
                }
                else if (inComment)
                {
                    if (code[i] == '\n')
                    {
                        inComment = false;
                        sb.Append(code[i]);
                    }
                }
            }
            return sb.ToString();
        }

        static void Read()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine());
                sb.Append('\n');
            }
            code = sb.ToString();
        }

        static void Main(string[] args)
        {
            Read();
            n = code.Length;
            string cleaned = Cleaning
                ();
            string cleaned2 = cleaned.Trim();
            cleaned2 = Regex.Replace(cleaned2, @"  +", "");
            for (int i = 0; i < 8; i++)
            {
                cleaned2 = Regex.Replace(cleaned2, @"[\r\n]+\t*[\r\n]*", "\n");
            }

            Console.WriteLine(cleaned2);
        }
    }
}
