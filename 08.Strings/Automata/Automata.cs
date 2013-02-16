using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automata
{
    class Automata
    {
        static void Main(string[] args)
        {
            string str = "ab<cd>yab<cd>yab<cd>yab<cd>yab<cd>yab<cd>yab<cd>yab<cd>yab<cd>yab<cd>y";
            StringBuilder sb = new StringBuilder();
            bool isInTag = false;
            bool isOutTag = true;
            foreach (var ch in str)
            {
                if (isOutTag)
                {
                    if (ch == '<')
                    {
                        isInTag = true;
                        isOutTag = false;
                    }
                    else
                    {
                        sb.Append(ch);
                    }
                }
                else if (isInTag)
                {
                    if (ch == '>')
                    {
                        isOutTag = true;
                        isInTag = false;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
