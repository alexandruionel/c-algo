using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string inputData=Console.ReadLine();
            int Numar =Convert.ToInt32(inputData);
            
            if(Numar == 100)
            {
                Console.WriteLine("C");
            }
            else
            {
                string[] digits = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
                string[] dozens = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
                int zeci=Numar/10;
                int unitati=Numar%10;
                string NumarRoman = (dozens[zeci]+digits[unitati]);
                Console.WriteLine(NumarRoman);
            }

        }
    }
}
