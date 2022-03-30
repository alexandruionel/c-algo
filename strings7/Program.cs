using System;


namespace strings7
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string inputData=Console.ReadLine();
            int numarLivezi = Convert.ToInt32(inputData);
            int[,] livezi = new int[numarLivezi, 3];

            //citire matrice
            for (int i = 0; i < numarLivezi; i++)
            {
                string line = Console.ReadLine();
                string[] stringNumbers = line.Split(' ');
                for (int j = 0; j < 3; j++)
                   livezi[i, j] = Convert.ToInt32(stringNumbers[j]);
            }


            //calculeaza numarul total de pomi de pe fiecare linie
            int[] sum =new int[numarLivezi];
            int index=0;
            for (int i = 0; i < numarLivezi; i++)
            {
                sum[i] = 0;
                index = i;
                
                
                for (int j = 0; j < 3; j++)
                {
                    sum[i]+=livezi[i,j];           
                }

               int totalPomi =sum[i];
               Console.WriteLine(string.Format("Livada {0}: {1}", index+1, totalPomi));
            }
            
            // calculeaza numarul total de meri din matrice
            
            int[] sumaMeri= new int[3];
            
            for(int j = 0;;)
            {
                sumaMeri[j] = 0;
                for(int i= 0; i < numarLivezi; i++)
                {
                    sumaMeri[j]+=livezi[i,j];
                    
                }
                int meri=sumaMeri[j];
                Console.WriteLine(string.Format("Meri :{0}",meri));
                break;
            }


            // calculeaza numarul total de peri din matrice
            int[] sumaPeri= new int[3];
            
            for(int j = 1;;)
            {
                sumaPeri[j] = 0;
                for(int i= 0; i < numarLivezi; i++)
                {
                    sumaPeri[j]+=livezi[i,j];
                    
                }
                int peri=sumaPeri[j];
                Console.WriteLine(string.Format("Peri :{0}",peri));
                break;
            }
            

            //calculeaza numarul total de ciresi din matrice

            int[] sumaCiresi= new int[3];
            
            for(int j = 2;;)
            {
                sumaCiresi[j] = 0;
                for(int i= 0; i < numarLivezi; i++)
                {
                    sumaCiresi[j]+=livezi[i,j];
                    
                }
                int ciresi=sumaCiresi[j];
                Console.WriteLine(string.Format("Ciresi :{0}",ciresi));
                break;
            }

           
            
        }
    }
}
