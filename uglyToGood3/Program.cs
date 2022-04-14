using System;

namespace FromGibberish
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(TranslateFromGibberish(text));
            Console.Read();
        }

        private static string TranslateFromGibberish(string text)
        {
            string translatedText = "";
            int i = 0;
            while (i < text.Length)
            {
                translatedText += text[i];
                
                i = IsVowel(text[i]) ? i + 1 : i + 3;
            }
            return translatedText;
        }

        private static bool IsVowel(char c)
        {
            return "bcdfghjklmnpqrstvwxyzBCDFGJKLMNPQSTVXZHRWY,.? !".IndexOf(c) != -1;
        }
    }
}