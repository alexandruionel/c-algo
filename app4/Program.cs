using System;


namespace app4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputData =Console.ReadLine();
            int numar=Convert.ToInt32(inputData);
            if ((numar / 1000) % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            if ((numar / 100) % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            if ((numar / 10) % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            if ((numar % 2) % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

        }
    }
}
