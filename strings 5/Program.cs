using System;


namespace strings_5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string input= Console.ReadLine();
            
            string[] cuvinte=input.Split(' ');

            int count = 1;
            while(count<=6)
            {
                
                count++;
                string nume=cuvinte+" ";
                input = Console.ReadLine();
            }
           
            Console.WriteLine(nume.Length);
           
           for(int i = 0; i < nume.Length; i++)
            {
               if(nume[i] == input && i<=3)
            {
                Console.WriteLine("echipa verde");
            }else
            {
                Console.WriteLine("echipa rosie");
            }
            }
           
           
            
            





        }
    }
}
