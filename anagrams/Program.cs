using System;


namespace functii_7_calcul_factorial
{
    internal class Program { 


        static void Main(string[] args)
        {
            
            string option = Console.ReadLine();
            
            int n= option.Length;
            int k=n;
            Console.WriteLine(aranjamente(n,k));
            
           
            

        }
       
    
            //Combination method
            static double aranjamente(int n, int k)
            {
                double factn = factorial(n);
           
                double factnk = factorial(n-k);
                double combination = factn / factnk;
                return combination;
            }

            //Factorial method
            static double factorial(int n)
            {
                double factorial = 1;
                for(int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
    }
    }

    
    


