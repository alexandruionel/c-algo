using System;


namespace functii_7_calcul_factorial
{
    internal class Program { 


        static void Main(string[] args)
{
                    string inputData = Console.ReadLine();
                    Console.WriteLine(Solution(inputData));
                }


                static char[] convert(string text) // converting string to char[]
                {
                    char[] newString = new char[text.Length];
                    for (int i = 0; i < text.Length; i++)
                    {
                        newString[i] = text[i];
                    }
                    return newString;
                }

                static double CalculateFctorial(double number) // calc. factorial
                {
                    double factorial = 1;
                    for (int i = 1; i <= number; i++)
                        factorial *= i;
                    return factorial;
                }

                static int CountOcc(string text, char zet) // counting occurrences
                {                     
                    int count = 0;
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == zet)
                        {
                            count++;
                        }
                    }
                    return count;
                }

                static double Solution(string text) // the soluton, counting occurences of
                                                    // each char in string and each factorial
                {
                    double net = 0;
                    double sol = 1;
                    char[] newText = convert(text);
                    for (int i = 0; i <= newText.Length; i++)
                    {
                        if (text.Length > 0)
                        {
                            net = CountOcc(text, newText[i]);
                            sol = sol * CalculateFctorial(net);

                            if (newText[i] == text[0])
                            { text = text.Trim(text[0]); }
                        }
                    }

                    double solution = CalculateFctorial(newText.Length) / sol;
                    return solution;
                }
    }}

    
    


