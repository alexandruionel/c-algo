using System;


namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int mic=0;
           
           string inputData=Console.ReadLine();

           while (inputData != "0"){
                int numar=Convert.ToInt32(inputData);
                if(numar<mic){
                    mic=numar;}
               
                inputData=Console.ReadLine();
            };
            if (mic>0)
            {
                Console.WriteLine(mic);
            }
            else
            {
                if (mic == 0) { 
                Console.WriteLine(0);}
                else {if(mic <0) {
                        Console.WriteLine(mic);}
            }



            
              
        
          





    

            
        }
    }
}}
