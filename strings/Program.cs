using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "stop" && input != "")
            {
                string inputType = "";
                bool onlyDigits = true;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < '0' || input[i] > '9')
                        onlyDigits = false;
                }

                if (onlyDigits)
                {
                    inputType = "numar";
                }

                if (input == "true" || input == "false")
                {
                    inputType = "valoare booleana";
                }

                if (inputType == "")
                {
                    inputType = "text";
                }

                Console.WriteLine(inputType);
                input = Console.ReadLine();
            }
        }
        }
    }

