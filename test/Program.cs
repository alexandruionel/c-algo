using System;

class Program
{
    static void Main(string[] args)
    {
        string line = Console.ReadLine();
        string result = "";
        int total = 0;

        while (line != "gata")
        {
            int number = Convert.ToInt32(line);
            total += number;
            result += total + " ";
            line = Console.ReadLine();
        }
        Console.WriteLine(result);
    }
}
