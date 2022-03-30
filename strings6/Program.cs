  using System;


namespace strings6
{
    internal class Program
    {
        static void Main(string[] args)

        {   string inputData=Console.ReadLine();
            int storesNumber = Convert.ToInt32(inputData);
            decimal[,] profits = new decimal[storesNumber, 4];

            //citire matrice
            for (int i = 0; i < storesNumber; i++)
            {
                string line = Console.ReadLine();
                string[] stringNumbers = line.Split(' ');
                for (int j = 0; j < 4; j++)
                   profits[i, j] = Convert.ToDecimal(stringNumbers[j]);
            }

            //calculeaza coloana din matrice cu cel mai mare profit
            decimal[] quartersTotals = new decimal[4];
            

            for (int j = 0; j < 4; j++)
            {
                quartersTotals[j] = 0;
                for (int i = 0; i < storesNumber; i++)
                    quartersTotals[j] += profits[i, j];
               
                          
            }
            decimal maxProfitQuarter = quartersTotals[0];
            decimal maxProfitQuarterIndex = 0;

            for (int i = 1; i < 4; i++)
            {
                if (quartersTotals[i] > maxProfitQuarter)
                {
                    maxProfitQuarter = quartersTotals[i];
                    maxProfitQuarterIndex = i;
                }
            }
            Console.WriteLine(string.Format("Trimestrul {0}: {1:F2}", maxProfitQuarterIndex + 1, maxProfitQuarter));
            //calculez linia din matrice cu cel mai mare profit
            decimal[] lineTotals = new decimal[storesNumber];
            

            for (int i = 0; i< storesNumber; i++)
            {
                lineTotals[i] = 0;
                for (int j = 0; j <4 ; j++)
                    lineTotals[i] += profits[i, j];
               
                          
            }
            decimal maxQuarter =lineTotals[0];
            decimal maxQuarterIndex = 0;

            for (int i = 1; i < storesNumber; i++)
            {
                if (lineTotals[i] > maxQuarter)
                {
                    maxQuarter = lineTotals[i];
                    maxQuarterIndex = i;
                }
            }
            Console.WriteLine(string.Format("Magazinul {0}: {1:F2}", maxQuarterIndex + 1, maxQuarter));
            
            
            

        }
    }
}
