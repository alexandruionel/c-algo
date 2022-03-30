using System;


namespace strings8_PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        { 
          
            
            string text = Console.ReadLine();
            string sep=text;
            string reverse=string.Empty;
            int count=0, i=0;int j=1;
            
           
            while(i< sep.Length)
            {
                int numar=sep.Length-j;
                if(sep[i] == sep[numar])
                {
                    count++;    
               }
                else
                {
                    break;
                }
                j++;
                i++;
            }
            Console.WriteLine(count);
          }  
    }
}
