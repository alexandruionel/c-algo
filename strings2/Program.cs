using System;


namespace strings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var array = s.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
