﻿using System;

namespace ToGibberishUgly
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string r = "";
           
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    r += " ";
                }
                if(s[i] == '.')
                {
                    r += ".";
                }
                if (s[i] == ',')
                {
                    r += ",";
                }
                if (s[i] == '?')
                {
                    r += "?";
                }
                if (s[i] == '!')
                {
                    r += "!";
                }

                if (s[i] == 97 || s[i] == 101 || s[i] == 105 || s[i] == 111 || s[i] == 117 || s[i] == 'A')
                {
                    r += s[i].ToString() + "p" + s[i].ToString().ToLower();
                }
                else
                {
                    string ss = s.ToLower();
                    if (ss[i] == 'a' || ss[i] == 'b' || ss[i] == 'c' || ss[i] == 'd' || ss[i] == 'e' || ss[i] == 'f' ||
                    ss[i] == 'g' || ss[i] == 'h' || ss[i] == 'i' || ss[i] == 'j' || ss[i] == 'k' || ss[i] == 'l' ||
                    ss[i] == 'm' || ss[i] == 'n' || ss[i] == 'o' || ss[i] == 'q' || ss[i] == 'p' || ss[i] == 'r' ||
                    ss[i] == 's' || ss[i] == 't' || ss[i] == 'u' || ss[i] == 'v' || ss[i] == 'w' || ss[i] == 'x' ||
                    ss[i] == 'y' || ss[i] == 'z' )
                    {
                        r += s[i];
                    }
                    
                } 

            }

            Console.WriteLine(r);
            Console.Read();
        }
    }
}
