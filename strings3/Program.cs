using System;

namespace _35 
{
    class Program
    {
        static void Main()
        {
            string rezultat="";
            string input=Console.ReadLine();
            while (input != "x")
            {int numar=Convert.ToInt32(input);
                if (numar >0)              
                {
                    
                       rezultat= rezultat+Convert.ToString(numar);
                       rezultat=rezultat+"\n";
                        
                    
                }
               input= Console.ReadLine();
            }
            if(rezultat == "")
            {
                Console.WriteLine("N/A");
            }
            else
            {
                Console.WriteLine(rezultat);
            }
            
        }
    }
}
