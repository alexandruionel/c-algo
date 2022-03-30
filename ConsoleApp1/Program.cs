using System;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int x=a, y=b;
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }
            Console.WriteLine((a*b)/x);
        }
    }
}
