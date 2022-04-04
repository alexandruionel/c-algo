using System;


namespace functii_7_calcul_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a =Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a - b;
            int x= fak(ref a);
            int y= fak(ref b);
            int z= fak(ref c);
            Console.WriteLine(x/(y*z));

        }

        public static int fak(ref int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                for (int i =number-1; i >0; i--)
                number= number * i;
                    
                
                
            }
            return number;

        }

    }
}
