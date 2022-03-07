using System;

namespace OddAndEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int requiredOddAndEvenNumbers = Convert.ToInt32(Console.ReadLine());
            int oddNumbersCount = 0;
            int evenNumbersCount = 0;
            while (oddNumbersCount < requiredOddAndEvenNumbers || evenNumbersCount < requiredOddAndEvenNumbers)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 == 0)
                {
                    evenNumbersCount++;
                    
                }
                else if (a != 0)
                {
                    oddNumbersCount++;
                    
                }
                
            }
            Console.WriteLine(evenNumbersCount + " " + oddNumbersCount);

        }
    }
}
