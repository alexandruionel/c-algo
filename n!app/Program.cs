using System;


namespace n_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputData=Console.ReadLine();
            int numar=Convert.ToInt32(inputData);
            int factorial = 1, k;
            
            if (numar > 1)
            {
                for ( k = 2; k <= numar; k++)
                {
                    factorial = factorial * k;
                                   };
               
                

                Console.WriteLine(factorial);
            }
            else
            {
                Console.WriteLine(factorial);
            }
        }
    }
}
