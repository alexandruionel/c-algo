using System;

namespace V1
{
    class Program
    {
        static void Main()
        {
                   
            
            string text = Console.ReadLine();
            string[] sep=text.Split(' ');
            string reverse=string.Empty;
            for (int i = sep.Length - 1; i >= 0; i--)
            {
                reverse += sep[i]+' ';
            }
            Console.Write (reverse);
            
                        

            

            
            
            
            
        }
    }
}
