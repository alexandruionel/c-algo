using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings_5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string input= Console.ReadLine();
            string total=string.Empty;
            int count = 1;
            while(count<6)
            {
                total += input;
                count++;
                input = Console.ReadLine();
            }
           Console.WriteLine(total);
            
            





        }
    }
}
