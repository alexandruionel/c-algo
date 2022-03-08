using System;


namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            int number=Convert.ToInt32(Console.ReadLine());
            string[] cuvinte=text.Split(' ');

            if (number <= cuvinte.Length)
            {
                Console.WriteLine(cuvinte[number-1]);
            }
            else
            {
                Console.WriteLine("N/A");
            }
            
            
            
        }
        }
    }

