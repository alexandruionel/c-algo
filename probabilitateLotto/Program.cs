using System;


namespace functii_7_calcul_factorial
{
    internal class Program { 


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            string option = Console.ReadLine();
            decimal result=0;
            int j=k;
            
            
            /*decimal result=Convert.ToDecimal(combination(k,cat)*combination(n-k,k-cat)/combination(n,k));*/
            

            if(option == "I")
                {
                   result=Convert.ToDecimal(combination(k,j)*combination(n-k,k-j)/combination(n,k));
                
                }else if(option == "II")
                {
                    result=Convert.ToDecimal(combination(k,j-1)*combination(n-k,k-(j-1))/combination(n,k));
                }else if(option == "III")
                {
                   result=Convert.ToDecimal(combination(k,j-2)*combination(n-k,k-(j-2))/combination(n,k));
                }
                else
                {
                     result=-1;
                }
            
            Console.WriteLine(Math.Round(result,10));
        }
       
    
            //Combination method
            static double combination(int n, int k)
            {
                double factn = factorial(n);
                double factk = factorial(k);
                double factnk = factorial(n-k);
                double combination = factn / (factnk * factk);
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

    
    

