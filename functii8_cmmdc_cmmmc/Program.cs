using System;


namespace functii8_cmmdc_cmmmc
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ulong nrA = Convert.ToUInt32(Console.ReadLine());
           ulong nrB = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine(CelMaiMareDivizorComun(nrA,nrB));
            Console.WriteLine(celmaimicmultiplucomun(nrA,nrB));
        }


        private static ulong CelMaiMareDivizorComun(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        private static ulong celmaimicmultiplucomun(ulong a,ulong b)
        {
            ulong x = a;
            ulong y = b;
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return (a * b) / x;
        }
    }
}
