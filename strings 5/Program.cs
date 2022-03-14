using System;


namespace strings_5
{
    internal class Program
    {
        static void Main(string[] args)

        {
           
           string totalElevi=string.Empty;
           for(int i=0; i<6; i++)
            {
               totalElevi =totalElevi+Console.ReadLine() +" ";
                
                
            }
           
           
           string[] echipe=totalElevi.Split(' ');
           
           string nume =Console.ReadLine();

            int k=0;

            while (k < echipe.Length)
            {
                
                if (k<3 && echipe[k]==nume)
            {
                Console.WriteLine("echipa verde");
                    break;
                }
               
                        
                 else if (k>=3&& echipe[k]==nume)
            {
                Console.WriteLine("echipa rosie");
                    break;
                }
                else if(echipe[0]!=nume&&echipe[1]!=nume&&echipe[2]!=nume&&echipe[3]!=nume&&echipe[4]!=nume&&echipe[5]!=nume)
                {
                    Console.WriteLine("N/A");
                    break;
                    
                }
                k++;
            }
            
            
   

        }
    }
}
