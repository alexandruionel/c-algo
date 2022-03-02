using System;
namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            double cashAmount = Convert.ToDouble(inputData);

            int breads = (int)Math.Floor(cashAmount / 5);
            breads = breads > 2 ? 2 : breads;
            Console.WriteLine(breads);

            double remainingCash = cashAmount - breads * 5;
            int eggs = (int)Math.Floor(remainingCash / 0.5);
            eggs = eggs > 10 ? 10 : eggs;
            Console.WriteLine(eggs);

            remainingCash -= eggs * 0.5;
            int apples = (int)Math.Floor(remainingCash / 3);
            apples = apples > 3 ? 3 : apples;
            Console.WriteLine(apples);

            if (breads == 2 && eggs == 10 && apples == 3)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }









        }
    }
    }

