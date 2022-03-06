using System;


namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int sum=0;
           int count = 0;
           string inputData=Console.ReadLine();

           while (inputData != "x"){
                int numar=Convert.ToInt32(inputData);
                sum +=numar;
                count++;
                inputData=Console.ReadLine();
            };
            if (count > 0)
            {
                Console.WriteLine((float) sum / count);
            }
            else
            {
                Console.WriteLine(0);
            }



            
              
        
          





    

            
        }
    }
}
