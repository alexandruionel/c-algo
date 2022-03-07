using System;


namespace positiveNumbersInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputData=Console.ReadLine();
            int count=0;
            while (inputData != "x")
            {
                int numar=Convert.ToInt32(inputData);
                if (numar > 0)
                {
                    count++;
                }
                inputData = Console.ReadLine();
                
              
            }
            Console.WriteLine(count);
        }
    }
}
