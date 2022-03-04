using System;
namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            string city = Convert.ToString(inputData);
            switch (city) 
            { 
                case "Paris":
                    Console.WriteLine("Franta");
                    break;
                case "Londra":
                    Console.WriteLine("Marea Britanie");
                    break;
                case "Madrid":
                    Console.WriteLine("Spania");
                    break;
                case "Berlin":
                    Console.WriteLine("Germania");
                    break;
                case "Roma":
                    Console.WriteLine("Italia");
                    break;        
                
                
                
              
              default:
                Console.WriteLine("oras invalid");
                break;
                
                    
                    
                    }
          }
           }
                    
                    
        }